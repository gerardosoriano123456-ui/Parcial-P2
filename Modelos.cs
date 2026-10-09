/* =========================================================================
 * ARCHIVO: Modelos.cs (Lógica de Negocio y POO)
 * ========================================================================= */

using System;
using System.Collections.Generic;

namespace practicaparcial
{
    // =====================================================================
    // EJERCICIO 3: Clases y Objetos
    // Lógica implementada por: Gerardo Soriano (2025-2481)
    // =====================================================================
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Presentarse()
        {
            return $"Hola, mi nombre es {Nombre} y tengo {Edad} años.";
        }
    }

    // =====================================================================
    // EJERCICIOS 4 y 5: Herencia y Polimorfismo
    // Lógica implementada por: Khiara Acevedo (2025-2005)
    // =====================================================================
    public abstract class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public abstract string HacerSonido();
    }

    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }

        public override string HacerSonido()
        {
            return $"{Nombre} (Perro) dice: Guau, guau";
        }
    }

    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre) { }

        public override string HacerSonido()
        {
            return $"{Nombre} (Gato) dice: Miau";
        }
    }

    // =====================================================================
    // EJERCICIO 6: Encapsulamiento
    // Lógica implementada por: Gerardo Soriano (2025-2481)
    // =====================================================================
    public class CuentaBancaria
    {
        // Atributo privado encapsulado
        private decimal saldo;

        public CuentaBancaria(decimal saldoInicial = 0)
        {
            saldo = saldoInicial;
        }

        public string Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                return "El monto a depositar debe ser mayor a $0.00.";
            }
            saldo += monto;
            return $"Depósito exitoso de ${monto:N2}. Nuevo saldo disponible: ${saldo:N2}";
        }

        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }

    // =====================================================================
    // EJERCICIO 7: Interfaces y Abstracción
    // Lógica implementada por: Gerardo Soriano (2025-2481)
    // =====================================================================
    public interface IVehiculo
    {
        string Encender();
        string Apagar();
    }

    public class Carro : IVehiculo
    {
        public string Encender()
        {
            return " El carro encendió su motor suavemente.";
        }

        public string Apagar()
        {
            return " El carro se ha apagado correctamente y activó la alarma.";
        }
    }

    public class Motocicleta : IVehiculo
    {
        public string Encender()
        {
            return "🏍 La motocicleta ruge con potencia al encender.";
        }

        public string Apagar()
        {
            return " La motocicleta se ha apagado y se colocó el parador central.";
        }
    }
}