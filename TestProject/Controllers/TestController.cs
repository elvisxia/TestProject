using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestProject.Models;
using System.Configuration;

namespace TestProject.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("GetById/v1/{id}")]
        public Test GetByIdV1(int id)
        {
            String connStr = ConfigurationManager.ConnectionStrings["TestContext"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr)) {
                conn.Open();
                List<Test> list = new List<Test>();
                using (SqlCommand command = new SqlCommand("SELECT * FROM TestTable where id="+id, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(
                                new Test
                                {
                                    Id = reader.GetInt64(0),
                                    Name = reader.GetString(1),
                                    Description = reader.GetString(2)
                                });

                        }
                    }
                }

                return list.FirstOrDefault();
            }
                
        }
        
        [HttpGet]
        [Route("GetById/v2/{id}")]
        public Test GetByIdV2(int id)
        {
            String connStr = ConfigurationManager.ConnectionStrings["TestContext"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                List<Test> list = new List<Test>();
                using (SqlCommand command = new SqlCommand("SELECT * FROM TestTable where id=" + id, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(
                                new Test
                                {
                                    Id = reader.GetInt64(0),
                                    Name = reader.GetString(1),
                                    Description = reader.GetString(2)
                                });

                        }
                    }
                }

                return list.FirstOrDefault();
            }

        }
        
        [HttpGet]
        [Route("GetById/v3/{id}")]
        public Test GetByIdV3(int id)
        {
            String connStr = ConfigurationManager.ConnectionStrings["TestContext"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                List<Test> list = new List<Test>();
                using (SqlCommand command = new SqlCommand("SELECT * FROM TestTable where id=" + id, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(
                                new Test
                                {
                                    Id = reader.GetInt64(0),
                                    Name = reader.GetString(1),
                                    Description = reader.GetString(2)
                                });

                        }
                    }
                }

                return list.FirstOrDefault();
            }

        }
        
        [HttpGet]
        [Route("GetById/v4/{id}")]
        public Test GetByIdV4(int id)
        {
            String connStr = ConfigurationManager.ConnectionStrings["TestContext"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                List<Test> list = new List<Test>();
                using (SqlCommand command = new SqlCommand("SELECT * FROM TestTable where id=" + id, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(
                                new Test
                                {
                                    Id = reader.GetInt64(0),
                                    Name = reader.GetString(1),
                                    Description = reader.GetString(2)
                                });

                        }
                    }
                }

                return list.FirstOrDefault();
            }

        }
    }
}
