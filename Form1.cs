/* =========================================================================
 * ARCHIVO: Form1.cs (Interfaz de Usuario y Lógica Form)
 * ========================================================================= */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practicaparcial
{
    public partial class Form1 : Form
    {
        private TabControl tabControl;
        private TabPage tabSintaxis, tabControlFlujo, tabPOO, tabVehiculos;

        // Ejercicio 1 y 2
        private TextBox txtNumeroEvaluar;
        private RichTextBox rtbSintaxis, rtbControl;

        // Ejercicios 3, 4, 5 y 6
        private RichTextBox rtbPresentacion, rtbAnimales, rtbBanco;
        private TextBox txtMontoDeposito;
        private CuentaBancaria cuentaMiembro;

        // Ejercicio 7
        private RichTextBox rtbVehiculos;

        public Form1()
        {
            InitializeComponent();
            ConfigurarFormulario();
            InicializarComponentesDinamicos();
            cuentaMiembro = new CuentaBancaria(500.00m);
        }

        // =================================================================
        // DISEÑO GENERAL DEL FORMULARIO
        // Implementado por: Khiara Acevedo (2025-2005)
        // =================================================================
        private void ConfigurarFormulario()
        {
            this.Text = "Práctica Parcial - Khiara Acevedo (2025-2005) & Gerardo Soriano (2025-2481)";
            this.Size = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(24, 24, 32);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        private void InicializarComponentesDinamicos()
        {
            tabControl = new TabControl { Dock = DockStyle.Fill, Padding = new Point(15, 8) };

            tabSintaxis = new TabPage { Text = "1. Variables", BackColor = Color.FromArgb(32, 33, 44) };
            tabControlFlujo = new TabPage { Text = "2. Control", BackColor = Color.FromArgb(32, 33, 44) };
            tabPOO = new TabPage { Text = "3-6. POO y Banco", BackColor = Color.FromArgb(32, 33, 44) };
            tabVehiculos = new TabPage { Text = "7. Interfaces", BackColor = Color.FromArgb(32, 33, 44) };

            ConstruirTabSintaxis();
            ConstruirTabControl();
            ConstruirTabPOO();
            ConstruirTabVehiculos();

            tabControl.TabPages.Add(tabSintaxis);
            tabControl.TabPages.Add(tabControlFlujo);
            tabControl.TabPages.Add(tabPOO);
            tabControl.TabPages.Add(tabVehiculos);

            this.Controls.Add(tabControl);
        }

        // =================================================================
        // EJERCICIO 1: Sintaxis Básica y Variables
        // Desarrollado por: Khiara Acevedo (2025-2005)
        // =================================================================
        private void ConstruirTabSintaxis()
        {
            Panel card = CrearCard(30, 20, 820, 520);
            card.Controls.Add(CrearTitulo("1. Bienvenida e Información del Grupo", 20, 15));

            Button btnEjecutar = CrearBoton("Mostrar Variables", 20, 60, Color.FromArgb(99, 102, 241));
            btnEjecutar.Click += (s, e) =>
            {
                // Declaración de variables requeridas (int, string, double, bool)
                string nombreGrupo = "Equipo Parcial C#";
                int totalIntegrantes = 2;
                double calificacionEsperada = 100.0;
                bool esTrabajoCompletado = true;

                rtbSintaxis.Clear();
                rtbSintaxis.AppendText("=====================================================\n");
                rtbSintaxis.AppendText("           BIENVENIDOS AL PROYECTO PARCIAL           \n");
                rtbSintaxis.AppendText("=====================================================\n\n");
                rtbSintaxis.AppendText($"-> Integrante 1: Khiara Acevedo (2025-2005)\n");
                rtbSintaxis.AppendText($"-> Integrante 2: Gerardo Soriano (2025-2481)\n\n");
                rtbSintaxis.AppendText($"[string] Nombre del Grupo: {nombreGrupo}\n");
                rtbSintaxis.AppendText($"[int] Cantidad de Integrantes: {totalIntegrantes}\n");
                rtbSintaxis.AppendText($"[double] Calificación Esperada: {calificacionEsperada} pts\n");
                rtbSintaxis.AppendText($"[bool] ¿Proyecto Completado?: {esTrabajoCompletado}\n");
            };
            card.Controls.Add(btnEjecutar);

            rtbSintaxis = CrearConsola(20, 120, 780, 370);
            card.Controls.Add(rtbSintaxis);

            tabSintaxis.Controls.Add(card);
        }

        // =================================================================
        // EJERCICIO 2: Estructuras de Control (Par/Impar y Bucle For)
        // Desarrollado por: Khiara Acevedo (2025-2005)
        // =================================================================
        private void ConstruirTabControl()
        {
            Panel card = CrearCard(30, 20, 820, 520);
            card.Controls.Add(CrearTitulo("2. Evaluación Par/Impar y Bucle For (1 al 10)", 20, 15));

            card.Controls.Add(CrearLabel("Ingresa un número entero:", 20, 65));
            txtNumeroEvaluar = CrearTextBox(20, 90, 200, "8");
            card.Controls.Add(txtNumeroEvaluar);

            Button btnProcesar = CrearBoton("Evaluar y Ejecutar For", 240, 88, Color.FromArgb(16, 185, 129));
            btnProcesar.Click += (s, e) =>
            {
                rtbControl.Clear();

                // Verificación de Par o Impar
                if (int.TryParse(txtNumeroEvaluar.Text, out int numero))
                {
                    if (numero % 2 == 0)
                        rtbControl.AppendText($"[EVALUACIÓN]: El número {numero} ingresado es PAR.\n\n");
                    else
                        rtbControl.AppendText($"[EVALUACIÓN]: El número {numero} ingresado es IMPAR.\n\n");
                }
                else
                {
                    rtbControl.AppendText("[ERROR]: Ingresa un valor numérico entero válido.\n\n");
                }

                // Bucle For del 1 al 10
                rtbControl.AppendText("=== BUCLE FOR (Imprimiendo números del 1 al 10) ===\n");
                for (int i = 1; i <= 10; i++)
                {
                    rtbControl.AppendText($"Número en secuencia: {i}\n");
                }
            };
            card.Controls.Add(btnProcesar);

            rtbControl = CrearConsola(20, 140, 780, 350);
            card.Controls.Add(rtbControl);

            tabControlFlujo.Controls.Add(card);
        }

        // =================================================================
        // EJERCICIOS 3, 4, 5 y 6: Objetos, Herencia, Polimorfismo y Banco
        // Desarrollado por: Gerardo Soriano (2025-2481)
        // =================================================================
        private void ConstruirTabPOO()
        {
            Panel card = CrearCard(30, 20, 820, 520);
            card.Controls.Add(CrearTitulo("3, 4, 5 y 6. Clases, Objetos, Herencia, Polimorfismo y Banco", 20, 15));

            // Ejercicio 3: Presentación del Grupo
            Button btnPresentar = CrearBoton("3. Presentar Integrantes", 20, 55, Color.FromArgb(99, 102, 241));
            btnPresentar.Width = 240;
            btnPresentar.Click += (s, e) =>
            {
                // Se crean los objetos Persona correspondientes a los dos integrantes
                Persona p1 = new Persona("Khiara Acevedo (2025-2005)", 20);
                Persona p2 = new Persona("Gerardo Soriano (2025-2481)", 21);

                rtbPresentacion.Clear();
                rtbPresentacion.AppendText($"{p1.Presentarse()}\n");
                rtbPresentacion.AppendText($"{p2.Presentarse()}\n");
            };
            card.Controls.Add(btnPresentar);

            rtbPresentacion = CrearConsola(20, 105, 780, 70);
            card.Controls.Add(rtbPresentacion);

            // Ejercicios 4 y 5: Herencia y Polimorfismo con List<Animal>
            Button btnAnimales = CrearBoton("4 y 5. Probar List<Animal>", 20, 190, Color.FromArgb(236, 72, 153));
            btnAnimales.Width = 240;
            btnAnimales.Click += (s, e) =>
            {
                List<Animal> animales = new List<Animal>
                {
                    new Perro("Rex"),
                    new Gato("Felix"),
                    new Perro("Toby")
                };

                rtbAnimales.Clear();
                rtbAnimales.AppendText("=== RECORRIENDO LISTA DE ANIMALES POLIMÓRFICA ===\n");
                foreach (var animal in animales)
                {
                    rtbAnimales.AppendText($"{animal.HacerSonido()}\n");
                }
            };
            card.Controls.Add(btnAnimales);

            rtbAnimales = CrearConsola(20, 235, 780, 90);
            card.Controls.Add(rtbAnimales);

            // Ejercicio 6: Encapsulamiento con CuentaBancaria
            card.Controls.Add(CrearLabel("6. Depositar saldo a la cuenta ($):", 20, 345));
            txtMontoDeposito = CrearTextBox(20, 370, 150, "300.00");
            card.Controls.Add(txtMontoDeposito);

            Button btnDepositar = CrearBoton("Realizar Depósito", 180, 368, Color.FromArgb(16, 185, 129));
            btnDepositar.Width = 180;
            btnDepositar.Click += (s, e) =>
            {
                if (decimal.TryParse(txtMontoDeposito.Text, out decimal monto))
                {
                    string res = cuentaMiembro.Depositar(monto);
                    rtbBanco.Clear();
                    rtbBanco.AppendText($"{res}\nSaldo verificado mediante ObtenerSaldo(): ${cuentaMiembro.ObtenerSaldo():N2}");
                }
                else
                {
                    MessageBox.Show("Monto inválido. Ingresa un número decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
            card.Controls.Add(btnDepositar);

            rtbBanco = CrearConsola(380, 345, 420, 145);
            card.Controls.Add(rtbBanco);

            tabPOO.Controls.Add(card);
        }

        // =================================================================
        // EJERCICIO 7: Interfaces y Abstracción (IVehiculo)
        // Desarrollado por: Gerardo Soriano (2025-2481)
        // =================================================================
        private void ConstruirTabVehiculos()
        {
            Panel card = CrearCard(30, 20, 820, 520);
            card.Controls.Add(CrearTitulo("7. Pruebas de Interface IVehiculo (Carro y Motocicleta)", 20, 15));

            Button btnProbarVehiculos = CrearBoton("Ejecutar Métodos de IVehiculo", 20, 60, Color.FromArgb(99, 102, 241));
            btnProbarVehiculos.Width = 270;
            btnProbarVehiculos.Click += (s, e) =>
            {
                IVehiculo miCarro = new Carro();
                IVehiculo miMoto = new Motocicleta();

                rtbVehiculos.Clear();
                rtbVehiculos.AppendText("=== PRUEBA DE CLASE CARRO (Implementa IVehiculo) ===\n");
                rtbVehiculos.AppendText($"{miCarro.Encender()}\n");
                rtbVehiculos.AppendText($"{miCarro.Apagar()}\n\n");

                rtbVehiculos.AppendText("=== PRUEBA DE CLASE MOTOCICLETA (Implementa IVehiculo) ===\n");
                rtbVehiculos.AppendText($"{miMoto.Encender()}\n");
                rtbVehiculos.AppendText($"{miMoto.Apagar()}\n");
            };
            card.Controls.Add(btnProbarVehiculos);

            rtbVehiculos = CrearConsola(20, 120, 780, 370);
            card.Controls.Add(rtbVehiculos);

            tabVehiculos.Controls.Add(card);
        }

        // =================================================================
        // MÉTODOS AUXILIARES DE DISEÑO
        // Creados conjuntamente (Khiara Acevedo & Gerardo Soriano)
        // =================================================================
        private Panel CrearCard(int x, int y, int w, int h) => new Panel { Location = new Point(x, y), Size = new Size(w, h), BackColor = Color.FromArgb(40, 42, 58) };
        private Label CrearTitulo(string t, int x, int y) => new Label { Text = t, Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold), ForeColor = Color.White };
        private Label CrearLabel(string t, int x, int y) => new Label { Text = t, Location = new Point(x, y), AutoSize = true, ForeColor = Color.LightGray };
        private TextBox CrearTextBox(int x, int y, int w, string p) => new TextBox { Location = new Point(x, y), Width = w, Text = p, BackColor = Color.FromArgb(24, 24, 32), ForeColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Font = new Font("Segoe UI", 11F) };
        private Button CrearBoton(string t, int x, int y, Color c) { Button b = new Button { Text = t, Location = new Point(x, y), Size = new Size(200, 38), BackColor = c, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold), Cursor = Cursors.Hand }; b.FlatAppearance.BorderSize = 0; return b; }
        private RichTextBox CrearConsola(int x, int y, int w, int h) => new RichTextBox { Location = new Point(x, y), Size = new Size(w, h), BackColor = Color.FromArgb(18, 18, 24), ForeColor = Color.FromArgb(129, 230, 217), BorderStyle = BorderStyle.None, ReadOnly = true, Font = new Font("Consolas", 10.5F) };
    }
}