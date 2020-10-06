using System;
using System.IO;

namespace Novelas_Literarias {
    public class NovelaLiteraria : IComparable<NovelaLiteraria>, IEquatable<NovelaLiteraria> {

        private long _lngISBN;
        private int _intNumeroDePaginas;
        private double _dblPrecio;
        private string _strTitulo;
        private char _chrClasificacionDeEdad;
        private DateTime _dtmFechaDePublicacion;
        private bool _blnTieneVersionDigital;
        private string _strRutaFotografia;
        private string _strAutor;
        private string _strEditorial;
        private string _strTipoDeEdicion;

        public NovelaLiteraria() {
        
        }

        public NovelaLiteraria(long lngId, int intNumeroDePaginas, double dblPrecio, string strTitulo,
            char chrClasificacionDeEdad, DateTime dtmFechaDePublicacion, bool blnTieneVersionDigital,
            string strRutaFotografia, string strAutor, string strEditorial, string strTipoDeEdicion) {
            _lngISBN = lngId;
            _intNumeroDePaginas = intNumeroDePaginas;
            _dblPrecio = dblPrecio;
            _strTitulo = strTitulo;
            _chrClasificacionDeEdad = chrClasificacionDeEdad;
            _dtmFechaDePublicacion = dtmFechaDePublicacion;
            _blnTieneVersionDigital = blnTieneVersionDigital;
            _strRutaFotografia = strRutaFotografia;
            _strAutor = strAutor;
            _strEditorial = strEditorial;
            _strTipoDeEdicion = strTipoDeEdicion;
        }
        public long ISBN {
            get => _lngISBN;
            set =>_lngISBN = value;
        }

        public string TipoDeEdicion {
            get => _strTipoDeEdicion;
            set => _strTipoDeEdicion = value;
        }



        public string Editorial {
            get => _strEditorial;
            set {
                if (!string.IsNullOrEmpty(value))
                    _strEditorial = value;
                else
                    throw new Exception("No deje la editorial vacia.");
            }
        }


        public string Autor {
            get => _strAutor;
            set {
                if (!string.IsNullOrEmpty(value))
                    _strAutor = value;
                else
                    throw new Exception("No deje el autor vacio.");
            }
        }


        public string RutaFotografia {
            get => _strRutaFotografia;
            set {
                if (File.Exists(value))
                    _strRutaFotografia = value;
                else
                    throw new Exception("No existe una fotografia en la ruta especificada.");
            }
        }


        public bool TieneVersionDigital {
            get => _blnTieneVersionDigital;
            set => _blnTieneVersionDigital = value;
        }


        public DateTime FechaDePublicacion {
            get => _dtmFechaDePublicacion;
            set {
                if (value != null && value.Date <= DateTime.Today)
                    _dtmFechaDePublicacion = value;
                else throw new Exception("Ingrese una fecha valida de publicacion.");
            }
        }


        public char ClasificacionDeEdad {
            get => _chrClasificacionDeEdad;
            set => _chrClasificacionDeEdad = value;
        }



        public string Titulo {
            get => _strTitulo;
            set {
                if (!string.IsNullOrEmpty(value))
                    _strTitulo = value;
                else throw new Exception("No deje el titulo vacio.");
            }
        }


        public double Precio {
            get => _dblPrecio;
            set {
                if (value >= 0)
                    _dblPrecio = value;
                else throw new Exception("Ingrese un precio mayor o igual a cero.");
            }
        }


        public int NumeroDePaginas {
            get => _intNumeroDePaginas;
            set {
                if (value > 0)
                    _intNumeroDePaginas = value;
                else throw new Exception("Ingrese un numero de paginas mayor a cero.");
            }
        }

        public int CompareTo(NovelaLiteraria other) {
            return Titulo.CompareTo(other.Titulo);
        }

        public bool Equals(NovelaLiteraria other) {
            return ISBN.Equals(other.ISBN);
        }

        public override string ToString() {
            return $"ISBN {ISBN}\nTitulo {Titulo}\nAutor {Autor}\nEditorial {Editorial}\nPrecio {Precio:C}";
        }
    }
}
