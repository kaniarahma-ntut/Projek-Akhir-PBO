using Project_Akhir.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Akhir
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Buat instance Form Login
            FormLogin login = new FormLogin();

            // 2. Tampilkan Login sebagai Dialog (jendela yang harus diselesaikan dulu)
            // Jika hasilnya OK (sesuai kode di Langkah 1), baru buka Main Form
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new HalUtama()); // Buka halaman utama
            }
            else
            {
                //Application.Exit(); // Jika login di-close/batal, matikan aplikasi
            }
        }
    }
}
