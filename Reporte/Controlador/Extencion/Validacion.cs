using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reporte.Controlador.Extencion
{
    public class Validacion
    {
        public static string _error = string.Empty;

        public static bool valor_requerido(params object[] validar)
        {
            bool ok = true;
            for (int i = 0; i < validar.Length; i++)
            {
                if (validar[i] is TextBox)
                {
                    (validar[i] as TextBox).Text = (validar[i] as TextBox).Text.Trim();
                    if((validar[i++] as TextBox).Text == "")
                    {
                        (validar[i - 1] as TextBox).BackColor = Color.LightSalmon;
                        _error = "\n- El campo " + validar[i].ToString() + " esta vacio";
                        ok = false;
                    }
                }
                if (validar[i] is MaskedTextBox)
                {
                    (validar[i] as MaskedTextBox).Text = (validar[i] as MaskedTextBox).Text.Trim();
                    if ((validar[i++] as MaskedTextBox).Text == "")
                    {
                        (validar[i - 1] as MaskedTextBox).BackColor = Color.LightSalmon;
                        _error = "\n- El campo " + validar[i].ToString() + " esta vacio";
                        ok = false;
                    }
                }
            }
            return ok;
        }
    }
}
