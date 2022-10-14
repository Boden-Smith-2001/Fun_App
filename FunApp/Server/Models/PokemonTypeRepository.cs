using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Shared;
using FunApp.Server.Models;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace teamDrummerCapstone.Server.Models
{
    public class PokemonTypeRepository
    {
        /// <summary>
        /// Create the appDbContext variable for dependency injection into the constructor - Dylan Albers
        /// </summary>
        private readonly DbConnection connection;

        /// <summary>
        /// Dependency Injection is happening - Dylan Albers
        /// </summary>
        /// <param name="connection"></param>
        public PokemonTypeRepository(DbConnection connection)
        {
            this.connection = connection;
        }

        // Creates a new appraisal note with the passed in object.
        public List<PokemonType> GetAllTypes()
        {
            List<PokemonType> pokemonTypes = new List<PokemonType>();
            // starts db connection.
            this.connection.OpenConnection();


            String sql = "Select type_Id, type from Pokemon_Types;";

            SqlCommand command = new SqlCommand(sql, this.connection.connected);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PokemonType type = new PokemonType
                {
                    Id = (int)reader.GetValue(0),
                    Type = reader.GetValue(1).ToString()
                };

                pokemonTypes.Add(type);
            }
            this.connection.CloseConnection();

            return pokemonTypes;
        }

        public bool CreateTypes(PokemonType typeAdded)
        {
            bool isGood = true;

            try
            {
                // starts db connection.
                this.connection.OpenConnection();


                String sql = "insert into PokemonTypes ";

                SqlCommand command = new SqlCommand(sql, this.connection.connected);

                this.connection.CloseConnection();
            }
            catch (Exception)
            {
                isGood = false;
            }

            return isGood;
        }
    }
}
