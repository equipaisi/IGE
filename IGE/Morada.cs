using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows.Forms;

// Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("IGE.Resources.cp.csv"))

namespace IGE
{
    public class CodigoPostal
    {
        #region Fields

        /// <summary>
        /// O CP4 são os primeiros 4 dígitos de um código postal.
        /// </summary>
        private readonly string _cp4;

        /// <summary>
        /// O CP3 são os últimos 3 dígitos de um código postal.
        /// </summary>
        private readonly string _cp3;

        private readonly string _localidade;

        #endregion

        #region Contructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cp">´Código postal no formato CP4-CP3</param>
        public CodigoPostal(string cp)
        {
            var enumerable = cp.Take(8);
            var letras = enumerable as IList<char> ?? enumerable.ToList();
            var cp4 = letras.Take(4);
            if (letras.Take(1).ToString() != "-")
            {
                throw new ArgumentException("Formato inválido: falta de hífen.");
            }
            var cp3 = letras.Take(4);

            _cp4 = cp4.ToString();
            _cp3 = cp3.ToString();
            _localidade = LookupLocalidade(_cp4, _cp3);
        }

        /// <summary>
        ///     Constrói um CodigoPostal a partir de um CP4 e um CP3.
        /// </summary>
        /// <param name="cp4"></param>
        /// <param name="cp3"></param>
        /// <exception cref="System.ArgumentNullException">description</exception>
        /// <exception cref="System.ArgumentException">description</exception>
        public CodigoPostal(string cp4, string cp3)
        {
            #region Error checking
            if (cp4 == null) throw new ArgumentNullException(nameof(cp4));
            if (cp3 == null) throw new ArgumentNullException(nameof(cp3));
            int icp4;
            if (!int.TryParse(cp4, out icp4)) throw new ArgumentException("cp4 must be parsable as an int");
            if (icp4 < 1000 || icp4 > 9999) throw new ArgumentException("cp4 must be a value beetween 1000 and 9999 (inclusive)");
            #endregion
            _cp4 = cp4;
            _cp3 = cp3;
            _localidade = LookupLocalidade(_cp4, _cp3);
        }

        #endregion

        #region Properties

        public string Cp4 => _cp4;
        public string Cp3 => _cp3;
        public string Localidade => _localidade;

        #endregion

        #region Methods

        /// <summary>
        /// Retorna uma localidade dado um conjunto de CP4 e CP3.
        /// </summary>
        /// <param name="cp4"></param>
        /// <param name="cp3"></param>
        /// <returns></returns>
        public static string LookupLocalidade(string cp4, string cp3)
        {
            // lookup localidade num ficheiro de texto
            throw new NotImplementedException();
        }

        public override string ToString() => $"{_cp4}-{_cp3} {_localidade}";

        #endregion
    }

    public class Morada
    {
        private readonly string _arruamento;
        private readonly int _numeroDaPorta;
        private readonly CodigoPostal _cp;

        public Morada(string arruamento, int numeroDaPorta, CodigoPostal cp)
        {
            Contract.Requires(arruamento != null);
            Contract.Requires(numeroDaPorta > 0);
            Contract.Requires(arruamento != null);
            _arruamento = arruamento;
            _numeroDaPorta = numeroDaPorta;
            _cp = cp;
        }

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

        public string Localidade
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A <see cref="T:System.String" /> containing a fully qualified type name.</returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString() => $"Rua: {_arruamento}, nº {_numeroDaPorta}\nCódigo Postal: {_cp}";
    }
}
