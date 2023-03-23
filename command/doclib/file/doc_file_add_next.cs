﻿using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.doclib.file
{
    /// <summary>
    /// Команда добавляет фрагмент двоичных данных к файлу у документа библиотеки документов
    public class doc_file_add_next : IParametersFunction
    {

        /// <summary>
        /// Идентификатор файла документа  
        /// </summary>
        public long iid_doc_file { get; set; }

        /// <summary>
        /// Двоичные данные
        /// </summary>
        public Byte file_data { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_doc_file", NpgsqlDbType.Bigint);
                Parameter.Value = iid_doc_file;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("file_data", NpgsqlDbType.Bytea);
                Parameter.Value = file_data;
                ListParameter.Add(Parameter);

                return ListParameter;
            }
        }

        /// <summary>
        /// Наименование функции API
        /// </summary>
        public string NameFunction
        {
            get
            {
                return "doc_file_add_next";
            }
        }
    }
}