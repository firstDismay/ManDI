﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user.add
{
    /// <summary>
    /// Команда добавляет новый объект в указанное расположение
    /// </summary>
    public class user_add : IParametersFunction
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string usr_name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string usr_otchestvo { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string usr_familiya { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string usr_rolname { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string usr_pwd { get; set; }

        /// <summary>
        /// Атрибут супер пользователь
        /// </summary>
        public bool usr_rolsuper { get; set; }

        /// <summary>
        /// Атрибут наследование ролей
        /// </summary>
        public bool usr_rolinherit { get; set; }

        /// <summary>
        /// Атрибут создание ролей
        /// </summary>
        public bool usr_rolcreaterole { get; set; }

        /// <summary>
        /// Атрибут создание баз данных
        /// </summary>
        public bool usr_rolcreatedb { get; set; }

        /// <summary>
        /// Атрибут подключение к серверу
        /// </summary>
        public bool usr_rolcanlogin { get; set; }

        /// <summary>
        /// Атрибут подключение к серверу через web
        /// </summary>
        public bool usr_rolcanweblogin { get; set; }

        /// <summary>
        /// Атрибут обход политик безопасности строк
        /// </summary>
        public bool usr_bypassrls { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("usr_name", NpgsqlDbType.Varchar);
                Parameter.Value = usr_name;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_otchestvo", NpgsqlDbType.Varchar);
                Parameter.Value = usr_otchestvo;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_familiya", NpgsqlDbType.Varchar);
                Parameter.Value = usr_familiya;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_rolname", NpgsqlDbType.Varchar);
                Parameter.Value = usr_rolname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_pwd", NpgsqlDbType.Varchar);
                Parameter.Value = usr_pwd;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_rolsuper", NpgsqlDbType.Boolean);
                Parameter.Value = usr_rolsuper;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_rolinherit", NpgsqlDbType.Boolean);
                Parameter.Value = usr_rolinherit;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_rolcreaterole", NpgsqlDbType.Boolean);
                Parameter.Value = usr_rolcreaterole;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_rolcreatedb", NpgsqlDbType.Boolean);
                Parameter.Value = usr_rolcreatedb;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_rolcanlogin", NpgsqlDbType.Boolean);
                Parameter.Value = usr_rolcanlogin;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_rolcanweblogin", NpgsqlDbType.Boolean);
                Parameter.Value = usr_rolcanweblogin;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("usr_bypassrls", NpgsqlDbType.Boolean);
                Parameter.Value = usr_bypassrls;
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
                return "user_add";
            }
        }

        public string? Condition { get; set; }
    }
}
