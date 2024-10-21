using FontAwesome.Sharp;
using ProyectoCompiladores.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProyectoCompiladores.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentChildView;
        private string _caption;
        private string _iconPath;

        public ViewModelBase CurrentChildView
        {
            get => _currentChildView;
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public string Caption
        {
            get => _caption;
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        public string IconPath
        {
            get => _iconPath;
            set
            {
                _iconPath = value;
                OnPropertyChanged(nameof(IconPath));
            }
        }

        public ICommand ShowCrearBasicoViewCommand { get; }

        public MainViewModel()
        {
            // Initialize command
            ShowCrearBasicoViewCommand = new ViewModelCommand(ExecuteShowCrearBasicoViewCommand);

            // Default view
            ExecuteShowCrearBasicoViewCommand(null);
        }
        
        private void ExecuteShowCrearBasicoViewCommand(object obj)
        {
            CurrentChildView = new CrearBasicoViewModel();
            Caption = "Crear AFN básico";
            IconPath = "/Images/CrearBasico.png";
        }
        //public MainViewModel()
        //{
        //    // Initialize command
        //    ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
        //    //ShowCustomViewCommand = new ViewModelCommand(ExecuteShowCustomViewCommand);
        //    ShowBebidasViewCommand = new ViewModelCommand(ExecuteShowBebidasViewCommand);
        //    ShowSopasViewCommand = new ViewModelCommand(ExecuteShowSopasViewCommand);
        //    ShowPlatoPolloViewCommand = new ViewModelCommand(ExecuteShowPlatoPolloViewCommand);
        //    ShowPlatoPescadoViewCommand = new ViewModelCommand(ExecuteShowPlatoPescadoViewCommand);
        //    ShowAgregarRecetaViewCommand = new ViewModelCommand(ExecuteShowAgregarRecetaViewCommand);

        //    // Default view
        //    ExecuteShowHomeViewCommand(null);
        //}

        //private void ExecuteShowBebidasViewCommand(object obj)
        //{
        //    CurrentChildView = new BebidasViewModel();
        //    Caption = "Unir AFN's";
        //    IconPath = "/Images/Icono2.png";
        //}

        //private void ExecuteShowSopasViewCommand(object obj)
        //{
        //    CurrentChildView = new SopasViewModel();
        //    Caption = "Sopas";
        //    IconPath = "/Images/Icono3.png";
        //}

        //private void ExecuteShowPlatoPolloViewCommand(object obj)
        //{
        //    CurrentChildView = new PlatosPolloViewModel();
        //    Caption = "Platos con Pollo";
        //    IconPath = "/Images/Icono4-1.png";
        //}

        //private void ExecuteShowPlatoPescadoViewCommand(object obj)
        //{
        //    CurrentChildView = new PlatosPescadoViewModel();
        //    Caption = "adsads";
        //    IconPath = "/Images/Icono4-2.png";
        //}

        //public void ExecuteShowAgregarRecetaViewCommand(object obj)
        //{
        //    Caption = "Agregar Receta";
        //    IconPath = "/Images/Icono6.png";
        //}
        ////private void ExecuteShowCustomViewCommand(object obj)
        ////{
        ////    CurrentChildView = new CustomViewModel();
        ////    Caption = "Custom";
        ////    IconPath = "/Images/Icono1.png";
        ////    Datos = _recetario.Recetas[1];
        ////}

        //private void ExecuteShowHomeViewCommand(object obj)
        //{
        //    CurrentChildView = new HomeViewModel();
        //    Caption = "Crear AFN básico";
        //    IconPath = "/Images/Icono1.png";
        //}
    }
}

