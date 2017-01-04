using System;
using System.Collections.Generic;
using System.Linq;

// Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("IGE.Resources.cp.csv"))

namespace Middleware
{
    /// <summary>
    /// Classe CodigoPostal.
    /// Representa um código postal no formato CP4-CP3 Localidade.
    /// </summary>
    public class CodigoPostal
    {
        #region Fields

        private string _cp;
        #endregion

        #region Contructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cp">Código postal no formato CP4-CP3</param>
        public CodigoPostal(string cp)
        {
            _cp = cp;
        }
        #endregion

        public override string ToString() => $"{_cp}";
    }

    public class Morada
    {
        private readonly string _arruamento;
        private readonly CodigoPostal _codigoPostal;
        private readonly string _localidade;

        public Morada(string arruamento, CodigoPostal codigoPostal)
        {
            _arruamento = arruamento;
            _codigoPostal = codigoPostal;
        }

        public Morada(string arruamento, CodigoPostal codigoPostal, string localidade)
        {
            _arruamento = arruamento;
            _codigoPostal = codigoPostal;
            _localidade = localidade;
        }

        public string Arruamento => _arruamento;

        public string CodigoPostal => _codigoPostal.ToString();

        // TODO: public string Localidade => _codigoPostal.Localidade ???
        public string Localidade => _localidade;

        public string Distrito
        {
            get { throw new NotImplementedException(); }
        }
        public string Concelho
        {
            get { throw new NotImplementedException(); }
        }
        public string Freguesia
        {
            get { throw new NotImplementedException(); }
        }


        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A <see cref="T:System.String" /> containing a fully qualified type name.</returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString() => $"Rua: {_arruamento}\nCódigo Postal: {_codigoPostal}\nLocalidade: {Localidade}";
    }
}
