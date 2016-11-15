using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Middleware
{
    /// <summary>
    /// Classe InstituicaoDeEnsino.
    /// Representa um conjunto de dados Intituição de Ensino, Curso e Ano.
    /// </summary>
    public class InstituicaoDeEnsino
    {
        /// <summary>
        /// Uma Instituição de Ensino.
        /// </summary>
        public string Instituicao { get; set; }
        /// <summary>
        /// Um curso nesta Instituição de Ensino.
        /// </summary>
        public string Curso { get; set; }
        /// <summary>
        /// O ano do curso que um determinado estudante frequenta.
        /// </summary>
        public uint Ano { get; set; }

        /// <summary>Returna uma string que representa uma InstituicaoDeEnsino.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() => $"{Instituicao} - {Curso} ({Ano}º ano)";
    }

    /// <summary>
    /// Interface IEstudante.
    /// Representa um estudante.
    /// </summary>
    public interface IEstudante//: IUtilizador
    {
        /// <summary>
        /// Retorna o nome completo do estudante.
        /// </summary>
        string Nome { get; set;  }

        /// <summary>
        /// A data de nascimento do estudante.
        /// <remarks>Obrigatório.</remarks>
        /// </summary>
        DateTime DataDeNascimento { get; set; }

        /// <summary>
        /// O género sexual do estudante.
        /// <remarks>Obrigatório.</remarks>
        /// </summary>
        GeneroSexual Genero { get; set; }

        /// <summary>
        /// A nacionalidade do estudante.
        /// <remarks>Obrigatório.</remarks>
        /// </summary>
        string Nacionalidade { get; set; }

        /// <summary>
        /// A morada atual do estudante.
        /// <remarks>Obrigatório.</remarks>
        /// </summary>
        Morada Morada { get; set; }

        #region Contactos
        MailAddress Email { get; set; }
        string Telemovel { get; set; }
        string Telefone { get; set; }
        #endregion

        /// <summary>
        /// Os perfis de redes sociais do estudante.
        /// <remarks>Não obrigatório.</remarks>
        /// </summary>
        IEnumerable<Tuple<RedeSocial, string>> PerfisRedesSociais { get; set; }

        InstituicaoDeEnsino Ensino { get; set; }

        /// <summary>
        /// Os interesses e gostos do estudante.
        /// <remarks>Não obrigatório.</remarks>
        /// </summary>
        IEnumerable<string> Interesses { get; set; }
    }

    /// <summary>
    /// Classe estudante.
    /// Implementa IEstudante.
    /// </summary>
    public class Estudante: IEstudante
    {
        /// <summary>
        /// Constrói um novo estudante.
        /// </summary>
        /// <param name="primeiroNome">Primeiro nome do Estudante.</param>
        /// <param name="ultimoNome">Último nome do Estudante.</param>
        /// <param name="nomesIntermedios">Nomes intermédios do Estudante.</param>
        /// <param name="dataDeNascimento">Data de nascimento do Estudante.</param>
        /// <param name="sexo">Género Sexual do Estudante.</param>
        /// <param name="ensino">InstituicaoDeEnsino (Instituição, Curso, Ano) do Estudante.</param>
        public Estudante(string primeiroNome, string ultimoNome, IEnumerable<string> nomesIntermedios, DateTime dataDeNascimento, GeneroSexual sexo, InstituicaoDeEnsino ensino)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            NomesIntermedios = nomesIntermedios ?? new List<string>();
            DataDeNascimento = dataDeNascimento; // TODO: check if is a valid datetime (not null, < DateTime.Now??)
            Genero = sexo;
            Ensino = ensino;
        }

        public IEnumerable<string> NomesIntermedios { get; set; }

        public string UltimoNome { get; set; }

        public string PrimeiroNome { get; set; }

        /// <summary>
        /// Retorna o nome do estudante.
        /// </summary>
        public string Nome
        {
            // TODO: refactor this into one line solution
            get
            {
                var names = new List<string> { PrimeiroNome };
                names.AddRange(NomesIntermedios);
                names.Add(UltimoNome);
                return string.Join(" ", names);
            }
            set
            {
                var names = value.Split(' ');
                var namesLength = names.Length;
                switch (namesLength)
                {
                    case 1:
                        PrimeiroNome = names[0];
                        NomesIntermedios = null;
                        UltimoNome = null;
                        break;
                    case 2:
                        PrimeiroNome = names[0];
                        NomesIntermedios = null;
                        UltimoNome = names[1];
                        break;
                    default:
                        PrimeiroNome = names[0];
                        NomesIntermedios = names.AsEnumerable().Skip(1).Take(namesLength - 2);
                        UltimoNome = names[1];
                        break;
                }
            }
        }

        public DateTime DataDeNascimento { get; set; }

        // TODO: account for locale, leep years, and all that jazz
        public int Idade()
        {
            var today = DateTime.Today;
            var age = today.Year - DataDeNascimento.Year;
            if (today.Month < DataDeNascimento.Month ||
                (today.Month == DataDeNascimento.Month && today.Day < DataDeNascimento.Day)) age--;
            return age;
        }

        public GeneroSexual Genero { get; set; }
        // TODO: on set -> validate?
        public string Nacionalidade { get; set; }
        public Morada Morada { get; set; }
        public IEnumerable<Tuple<RedeSocial, string>> PerfisRedesSociais { get; set; }
        public InstituicaoDeEnsino Ensino { get; set; }
        public MailAddress Email { get; set; }
        public string Telemovel { get; set; }
        public string Telefone { get; set; }
        public IEnumerable<string> Interesses { get; set; }

        // TODO: completar
        public override string ToString() => $"Estudante:\nNome: {Nome}\nData de Nascimento: {DataDeNascimento}\nSexo: {Genero}";
    }
}
