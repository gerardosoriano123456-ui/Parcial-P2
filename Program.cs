/* =========================================================================
 * PROYECTO PARCIAL DE PROGRAMACIÓN ORIENTADA A OBJETOS
 * 
 * INTEGRANTES DEL GRUPO:
 * 1. Khiara Acevedo   - Matrícula: 2025-2005
 * 2. Gerardo Soriano  - Matrícula: 2025-2481
 * 
 * ARCHIVO: Program.cs (Punto de Entrada)
 * ========================================================================= */

using System;
using System.Windows.Forms;

namespace practicaparcial
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Trabajo Conjunto (Khiara Acevedo & Gerardo Soriano)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}