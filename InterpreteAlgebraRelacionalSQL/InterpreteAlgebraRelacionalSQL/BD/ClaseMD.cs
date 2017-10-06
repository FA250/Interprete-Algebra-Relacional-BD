using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreteAlgebraRelacionalSQL.BD
{
    class ClaseMD
    {
        ClaseConexion conexion = new ClaseConexion();

        //---------------- Verificar BD Exista ---------------- 
        public String verificar_BD(String BD)
        {
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Verificar_BD ?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION
            String Resultado = "";

            //Buscar los campos solicitados
            while (Contenedor.Read())
            {
                Resultado = Contenedor["Resultado"].ToString();
            }//CONTENEDOR READ

            Contenedor.Close();//Cierra contenedor con los datos seleccionados

            return Resultado;//devuelve los datos necesarios
        }

        //---------------- Verificar tabla Exista ----------------
        public String verificar_Tabla(String BD,String Tabla)
        {
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Verificar_Tabla ?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(Tabla, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION
            String Resultado = "";

            //Buscar los campos solicitados
            while (Contenedor.Read())
            {
                Resultado = Contenedor["Resultado"].ToString();
            }//CONTENEDOR READ

            Contenedor.Close();//Cierra contenedor con los datos seleccionados

            return Resultado;//devuelve los datos necesarios
        }

        //---------------- Seleccionar nombre de tablas ----------------
        public ArrayList select_NombreTablas(String BD)
        {
            ArrayList tablas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Nombre_tablas ?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);


            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor == null)
            {
                tablas = null;
                return tablas;
            }
            else
            {
                //Buscar los campos solicitados
                while (Contenedor.Read())
                {
                    ArrayList nombreSchema = new ArrayList();
                    nombreSchema.Add(Contenedor["TABLE_NAME"].ToString());
                    nombreSchema.Add(Contenedor["TABLE_SCHEMA"].ToString());

                    tablas.Add(nombreSchema);
                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados

                return tablas;//devuelve los datos necesarios
            }
        }

        //---------------- Seleccionar nombre Columnas ----------------
        public ArrayList select_NombreColumnas(String BD, String tabla,String esquema)
        {
            ArrayList columnas=new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Nombre_Columnas ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);
            conexion.annadir_parametro(esquema, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            //Buscar los campos solicitados
            while (Contenedor.Read())
            {               
                columnas.Add(Contenedor["COLUMN_NAME"].ToString());
            }//CONTENEDOR READ

            Contenedor.Close();//Cierra contenedor con los datos seleccionados

            return columnas;//devuelve los datos necesarios
        }

        //---------------- Seleccionar tablas existentes ----------------
        public ArrayList Seleccionar_tabla(String BD, String tabla, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Seleccionar_tabla ?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            //Buscar los campos solicitados
            while (Contenedor.Read())
            {
                foreach (String columna in columnas)
                {
                    atributos.Add(Contenedor[columna.ToString()].ToString());
                }
                tuplas.Add(atributos);
                atributos = new ArrayList();

            }//CONTENEDOR READ

            Contenedor.Close();//Cierra contenedor con los datos seleccionados


            return tuplas;//devuelve los datos necesarios
        }

        //---------------- Crear vista diccionario ----------------
        public void Crear_view_diccionario(String BD)
        {
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Crear_view_diccionario ?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor!=null)
            {
                Contenedor.Close();//Cierra contenedor con los datos seleccionados
            }
            //Buscar los campos solicitados
            /*while (Contenedor.Read())
            {
                foreach (String columna in columnas)
                {
                    atributos.Add(Contenedor[columna.ToString()].ToString());
                }
                tuplas.Add(atributos);
                atributos = new ArrayList();

            }//CONTENEDOR READ           


            return tuplas;*///devuelve los datos necesarios
        }

        //---------------- Borrar vista diccionario ----------------
        public void Borrar_view_diccionario(String BD)
        {
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Borrar_view_diccionario ?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor != null)
            {
                Contenedor.Close();//Cierra contenedor con los datos seleccionados
            }
            //Buscar los campos solicitados
            /*while (Contenedor.Read())
            {
                foreach (String columna in columnas)
                {
                    atributos.Add(Contenedor[columna.ToString()].ToString());
                }
                tuplas.Add(atributos);
                atributos = new ArrayList();

            }//CONTENEDOR READ

            


            return tuplas;*/
            //devuelve los datos necesarios
        }

        //---------------- Crear una tabla temporal ----------------
        public String Crear_tabla_temp(String BD, String tabla,String NConsulta)
        {

            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Crear_tabla_temp ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);
            conexion.annadir_parametro(NConsulta, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION
            if (Contenedor == null)
            {
                return null;
            }
            else
            {
                return "a";

                while (Contenedor.Read()) { }//CONTENEDOR READ
            }
        }

        //---------------- Borrar una tabla temporal ----------------
        public String Borrar_tabla_temp(String BD, String tabla)
        {

            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Borrar_tabla_temp ?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION
            if (Contenedor == null)
            {
                return null;
            }
            else
            {
                return "a";

                while (Contenedor.Read()) { }//CONTENEDOR READ
            }
        }

        //---------------- Seleccionar datos de una tabla ----------------
        public ArrayList Datos_tabla(String BD, String tabla)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Datos_tabla ?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            //Buscar los campos solicitados
            while (Contenedor.Read())
            {
                atributos.Add(Contenedor["COLUMN_NAME"].ToString());
                atributos.Add(Contenedor["DATA_TYPE"].ToString());
                atributos.Add(Contenedor["CHARACTER_MAXIMUM_LENGTH"].ToString());
                atributos.Add(Contenedor["NUMERIC_PRECISION"].ToString());
                atributos.Add(Contenedor["NUMERIC_SCALE"].ToString());
                atributos.Add(Contenedor["Primaria"].ToString());
                atributos.Add(Contenedor["Foranea"].ToString());
                atributos.Add(Contenedor["CHECK_CLAUSE"].ToString());

                tuplas.Add(atributos);
                atributos = new ArrayList();

            }//CONTENEDOR READ

            Contenedor.Close();//Cierra contenedor con los datos seleccionados


            return tuplas;//devuelve los datos necesarios
        }

        //---------------- Operacion de seleccion ----------------
        public ArrayList Operacion_Seleccion(String BD, String tabla, String predicado, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Seleccion ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);
            conexion.annadir_parametro(predicado, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor == null)
            {
                tuplas = null;
                return tuplas;
            }
            else
            {
                //Buscar los campos solicitados
                while (Contenedor.Read())
                {
                    foreach (String columna in columnas)
                    {
                        atributos.Add(Contenedor[columna.ToString()].ToString());
                    }
                    tuplas.Add(atributos);
                    atributos = new ArrayList();

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion de Proyeccion ----------------
        public ArrayList Operacion_proyeccion(String BD, String listaAtributos, String tabla, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_proyeccion ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(listaAtributos, 2);
            conexion.annadir_parametro(tabla, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor == null)
            {
                tuplas = null;
                return tuplas;
            }
            else
            {
                //Buscar los campos solicitados
                while (Contenedor.Read())
                {
                    foreach (String columna in columnas)
                    {
                        atributos.Add(Contenedor[columna.ToString()].ToString());
                    }
                    tuplas.Add(atributos);
                    atributos = new ArrayList();

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }

        //---------------- Columnas del producto Cartesiano ----------------
        public ArrayList Columnas_cartesiano(String BD, String tabla1, String tabla2)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_cartesiano ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(tabla2, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor == null)
            {
                columnas = null;
                return columnas;
            }
            else
            {
                //Buscar los campos solicitados
                while (Contenedor.Read())
                {

                    columnas.Add(Contenedor["COLUMN_NAME"].ToString());


                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion de Producto Cartesiano ----------------
        public ArrayList Operacion_producto_cartesiano(String BD, String tabla1, String tabla2, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_producto_cartesiano ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(tabla2, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor == null)
            {
                tuplas = null;
                return tuplas;
            }
            else
            {
                //Buscar los campos solicitados
                while (Contenedor.Read())
                {
                    foreach (String columna in columnas)
                    {
                        atributos.Add(Contenedor[columna.ToString()].ToString());
                    }
                    tuplas.Add(atributos);
                    atributos = new ArrayList();

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }


        //----- FIN -----
    }
}
