using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net.Mail;

namespace Middleware
{
    public class InstituicaoEnsino
    {
        public string Instituicao { get; set; }
        public string Curso { get; set; }
        public uint Ano { get; set; }

        public override string ToString() => $"{Instituicao} - {Curso} ({Ano}º ano)";
    }

    /// <summary>
    /// Interface IEstudante
    /// </summary>
    public interface IEstudante//: IUtilizador
    {
        /// <summary>
        /// Retorna o nome completo do estudante.
        /// </summary>
        string Nome { get; }

        /// <summary>
        /// A data de nascimento do estudante.
        /// <remarks>Obrigatório.</remarks>
        /// </summary>
        DateTime DataDeNascimento { get; }

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

        InstituicaoEnsino Ensino { get; set; }

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
        /// <param name="ensino">InstituicaoEnsino (Instituição, Curso, Ano) do Estudante.</param>
        public Estudante(string primeiroNome, string ultimoNome, IEnumerable<string> nomesIntermedios, DateTime dataDeNascimento, GeneroSexual sexo, InstituicaoEnsino ensino)
        {
            Contract.Requires<ArgumentException>(!string.IsNullOrWhiteSpace(primeiroNome), "Primeiro nome do funcionário não pode ser null ou vazio");
            Contract.Requires<ArgumentException>(!string.IsNullOrWhiteSpace(ultimoNome), "Último nome do funcionário não pode ser null ou vazio");
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            NomesIntermedios = nomesIntermedios ?? new List<string>();
            DataDeNascimento = dataDeNascimento; // TODO: check if is a valid datetime (not null, < DateTime.Now??)
            Genero = sexo;
            Ensino = ensino;
        }

        public IEnumerable<string> NomesIntermedios { get; }

        public string UltimoNome { get; }
    
        public string PrimeiroNome { get; }

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
        }

        public DateTime DataDeNascimento { get; }

        // TODO: account for locale, leep years, and all that jazz
        public int Idade
        {
            get { throw new NotImplementedException(); }
        }

        public GeneroSexual Genero { get; set; }
        // TODO: on set -> validate?
        public string Nacionalidade { get; set; }
        public Morada Morada { get; set; }
        public IEnumerable<Tuple<RedeSocial, string>> PerfisRedesSociais { get; set; }
        public InstituicaoEnsino Ensino { get; set; }
        public MailAddress Email { get; set; }
        public string Telemovel { get; set; }
        public string Telefone { get; set; }
        public IEnumerable<string> Interesses { get; set; }

        // TODO: completar
        public override string ToString() => $"Estudante:\nNome: {Nome}\nData de Nascimento: {DataDeNascimento}\nSexo: {Genero}";
    }
}
