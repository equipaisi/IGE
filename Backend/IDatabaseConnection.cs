﻿using System;
using System.Threading.Tasks;

namespace Backend
{
    /// <summary>
    ///     Representa uma conexão à base de dados.
    /// </summary>
    public interface IDatabaseConnection : IDisposable, ICloneable
    {
        /// <summary>
        ///     Abre uma nova conexão à base de dados.
        /// </summary>
        void Open();

        /// <summary>
        ///     Fecha a conexão atual à base de dados.
        /// </summary>
        void Close();

        /// <summary>
        ///     Abre uma nova conexão à base de dados assincronamente.
        /// </summary>
        /// <returns>Uma task representando uma operação assíncrona.</returns>
        Task OpenAsync();

        /// <summary>
        ///     Fecha a conexão atual à base de dados assincronamente.
        /// </summary>
        /// <returns>Uma task representando uma operação assíncrona.</returns>
        Task CloseAsync();
    }
}