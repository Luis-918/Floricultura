using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Floricultura
{
    namespace Floricultura
    {
        public static class Navegacao
        {
            private static readonly Dictionary<Type, Form> _paginas = new Dictionary<Type, Form>();

            //Registra a página principal (a que abre junto com o programa)
            public static void Registrar(Form form)
            {
                _paginas[form.GetType()] = form;
            }

            public static void IrPara<T>(Form atual) where T : Form, new()
            {
                if (atual is T) return;//já está nessa página

                Form destino;
                if (!_paginas.TryGetValue(typeof(T), out destino) || destino.IsDisposed)
                {
                    destino = new T();
                    destino.FormClosed += (s, e) => Application.Exit();//fechar qualquer página encerra o programa
                    _paginas[typeof(T)] = destino;
                }

                destino.StartPosition = FormStartPosition.Manual;
                destino.Location = atual.Location;
                destino.Size = atual.Size;
                destino.WindowState = atual.WindowState;

                destino.Show();
                atual.Hide();
            }
        }
    }// fim da classe
}// fim do projeto