# Test Project - API Test Project

## Usage

For quick start of this app, make break points in `GetByIdV1/V2/V3/V4` methods of TestController.cs file.
Run the app with visual studio 2015, and type in the location of browser "http://localhost:*port*/api/Test/GetbyId/v2/1", and you will see the break point run into the right method.

## Full Usage
Well, you need to create a table on your SQL first.

Config the connection string in `web.config` `<connectionStrings>` tag

modify every method of GetByIdVn method to retrieve the right fields of your table:

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

## Remark
This sample use convention-based routing and attributing routing of .Net WebApi to control the api version.
convention-based routing:

        public static class WebApiConfig
        {
            public static void Register(HttpConfiguration config)
            {
                // Web API configuration and services

                // Web API routes
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{action}/{version}/{id}",
                    defaults: new {
                        controller ="Test",
                        id = RouteParameter.Optional,
                        action ="GetById",
                        version ="v1"}
                );
            }
        }
attributing routing:

            [Route("GetById/v1/{id}")]
            public Test GetByIdV1(int id)
        
*Note: I'm currently considering how to put all routeTemplates together for better management*

For Sql-Connection I simply used SqlConnection class, EntityFramwork can be used in production environment.
