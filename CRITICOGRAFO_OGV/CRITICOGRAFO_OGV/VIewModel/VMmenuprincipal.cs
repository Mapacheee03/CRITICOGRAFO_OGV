using ExamenU4Daps.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace CRITICOGRAFO_OGV.ViewModel
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Nombre;
        bool _Hombre;
        bool _Mujer;
        bool _Alto;
        bool _Feo;
        bool _Listo;
        bool _Extravagante;
        bool _Raro;
        bool _Grande;
        string _MostrarCriticas;
        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Nombre
        {
            get { return _Nombre; }
            set { SetValue(ref _Nombre, value); }
        }

        public bool Hombre
        {
            get { return _Hombre; }
            set { SetValue(ref _Hombre, value); }
        }

        public bool Mujer
        {
            get { return _Mujer; }
            set { SetValue(ref _Mujer, value); }
        }

        public bool Alto
        {
            get { return _Alto; }
            set { SetValue(ref _Alto, value); }
        }

        public bool Feo
        {
            get { return _Feo; }
            set { SetValue(ref _Feo, value); }
        }

        public bool Listo
        {
            get { return _Listo; }
            set { SetValue(ref _Listo, value); }
        }

        public bool Extravagante
        {
            get { return _Extravagante; }
            set { SetValue(ref _Extravagante, value); }
        }

        public bool Raro
        {
            get { return _Raro; }
            set { SetValue(ref _Raro, value); }
        }

        public bool Grande
        {
            get { return _Grande; }
            set { SetValue(ref _Grande, value); }
        }

        public string MostrarCriticas
        {
            get { return _MostrarCriticas; }
            set { SetValue(ref _MostrarCriticas, value); }
        }
        #endregion

        #region PROCESOS
        public void GenerarCriticas()
        {
            string nombre = Nombre;
            string genero = "";
            if (Hombre)
            {
                genero = "Hombre";
            }
            else if (Mujer)
            {
                genero = "Mujer";
            }
            List<string> caracteristicasSeleccionadas = new List<string>();

            if (Alto)
            {
                caracteristicasSeleccionadas.Add(genero == "Mujer" ? "alta" : "alto");
            }
            if (Feo)
            {
                caracteristicasSeleccionadas.Add(genero == "Mujer" ? "fea" : "feo");
            }
            if (Listo)
            {
                caracteristicasSeleccionadas.Add(genero == "Mujer" ? "lista" : "listo");
            }
            if (Extravagante)
            {
                caracteristicasSeleccionadas.Add("extravagante");
            }
            if (Raro)
            {
                caracteristicasSeleccionadas.Add(genero == "Mujer" ? "rara" : "raro");
            }
            if (Grande)
            {
                caracteristicasSeleccionadas.Add("grande");
            }

            // Construir la cadena de salida
            string critica = $"{nombre} eres ";

            if (caracteristicasSeleccionadas.Count == 1)
            {
                critica += caracteristicasSeleccionadas[0];
            }
            else if (caracteristicasSeleccionadas.Count == 2)
            {
                critica += $"{caracteristicasSeleccionadas[0]} y {caracteristicasSeleccionadas[1]}";
            }
            else if (caracteristicasSeleccionadas.Count > 2)
            {
                for (int i = 0; i < caracteristicasSeleccionadas.Count - 1; i++)
                {
                    critica += $"{caracteristicasSeleccionadas[i]}, ";
                }
                critica += $"y {caracteristicasSeleccionadas[caracteristicasSeleccionadas.Count - 1]}";
            }

            critica += ".";

            // Mostrar la crítica en la interfaz de usuario
            MostrarCriticas = critica;
        }
        #endregion

        #region COMANDOS
        public ICommand MostrarCriticasCommand => new Command(GenerarCriticas);
        #endregion
    }
}
