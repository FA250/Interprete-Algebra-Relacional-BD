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


        //---------------- Seleccionar nombre de todos los atributos de la BD ----------------
        public ArrayList Todos_atributos(String BD)
        {
            ArrayList tablas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Todos_atributos ?";//numero de parametros
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
                    tablas.Add(Contenedor["COLUMN_NAME"].ToString());
                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados

                return tablas;//devuelve los datos necesarios
            }
        }

        //---------------- Cantidad de columnas de una tabla ----------------
        public int cant_Columnas(String BD,String tabla)
        {
            int columnas = 0;
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC cant_Columnas ?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);


            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor == null)
            {
                columnas = -1;
                return columnas;
            }
            else
            {
                //Buscar los campos solicitados
                while (Contenedor.Read())
                {
                    columnas=Convert.ToInt32(Contenedor["cantidad"]);
                    

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados

                return columnas;//devuelve los datos necesarios
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

        //---------------- Columnas de renombrar ----------------
        public ArrayList Columnas_renombrar(String BD, String tabla, String nuevaTabla, String nuevosAtributos)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_renombrar ?,?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);
            conexion.annadir_parametro(nuevaTabla, 2);
            conexion.annadir_parametro(nuevosAtributos, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor == null)
            {
                columnas = null;
                return columnas;
            }
            else
            {
                Contenedor.Close();//Cierra contenedor con los datos seleccionados

                return columnas;//devuelve los datos necesarios
            }

        }

        //---------------- Columnas de renombrar ----------------
        public ArrayList Columnas_renombrar2(String BD, String nuevaTabla)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_renombrar2 ?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(nuevaTabla, 2);

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
                    columnas.Add(Contenedor["name"].ToString());

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion renombrar ----------------
        public ArrayList Operacion_renombrar(String BD, String tabla,ArrayList columnas)
        {
            ArrayList atributos = new ArrayList();
            ArrayList tuplas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_renombrar ?,?";//numero de parametros
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
                //Buscar los campos solicitados
                while (Contenedor.Read())
                {
                    int i = 0;
                    foreach(String columna in columnas)
                    {
                        atributos.Add(Contenedor[i].ToString());
                        i++;
                    }
                    tuplas.Add(atributos);
                    atributos = new ArrayList();

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
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

        //---------------- Seleccionar datos de un atributo ----------------
        public ArrayList Datos_atributos(String BD, String atributo)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Datos_atributos ?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(atributo, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            //Buscar los campos solicitados
            while (Contenedor.Read())
            {
                atributos.Add(Contenedor["TABLE_NAME"].ToString());
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

        //---------------- Validacion de dominio----------------
        public ArrayList Validar_dominio(String BD, String tabla, String tabla2)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();

            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Validar_dominio ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);
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

                    atributos.Add(Contenedor["COLUMN_NAME"].ToString());
                    atributos.Add(Contenedor["ORDINAL_POSITION"].ToString());
                    atributos.Add(Contenedor["TABLE_NAME"].ToString());
                    atributos.Add(Contenedor["DATA_TYPE"].ToString());
                    atributos.Add(Contenedor["CHARACTER_MAXIMUM_LENGTH"].ToString());
                    atributos.Add(Contenedor["NUMERIC_PRECISION"].ToString());

                    tuplas.Add(atributos);
                    atributos = new ArrayList();

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }

        //---------------- Diferencia simetrica de 2 tablas tomando en cuenta nombre columna ----------------
        public ArrayList Diferencia_simetrica_nombre(String BD, String tabla, String tabla2)
        {
            ArrayList tuplas = new ArrayList();            

            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Diferencia_simetrica_nombre ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);
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
                    tuplas.Add(Contenedor["COLUMN_NAME"].ToString());                    

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }

        //---------------- Atributos iguales entre 2 tablas ----------------
        public ArrayList Atributos_iguales(String BD, String tabla, String tabla2)
        {
            ArrayList tuplas = new ArrayList();

            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Atributos_iguales ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);
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
                    tuplas.Add(Contenedor["COLUMN_NAME"].ToString());

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }
        //---------------- Operacion de division ----------------
        public ArrayList Operacion_division(String BD, String tabla, String tabla2, String listAtributos, String predicado1, String predicado2, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_division ?,?,?,?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);
            conexion.annadir_parametro(tabla2, 2);
            conexion.annadir_parametro(listAtributos, 2);
            conexion.annadir_parametro(predicado1, 2);
            conexion.annadir_parametro(predicado2, 2);

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

        

        //---------------- Columnas de la proyeccion ----------------
        public ArrayList Columnas_proyeccion(String BD, String tabla1, String listaAtributos)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_proyeccion ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(listaAtributos, 2);

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

                    columnas.Add(Contenedor["name"].ToString());


                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
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

                    columnas.Add(Contenedor["name"].ToString());


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
                    int i=0;
                    foreach (String columna in columnas)
                    {
                        atributos.Add(Contenedor[i].ToString());
                        i++;
                    }
                    tuplas.Add(atributos);
                    atributos = new ArrayList();

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }

        //---------------- Columnas de la Union ----------------
        public ArrayList Columnas_union(String BD, String tabla1, String tabla2)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_union ?,?,?";//numero de parametros
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

                    columnas.Add(Contenedor["name"].ToString());


                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion de Union ----------------
        public ArrayList Operacion_union(String BD, String tabla1, String tabla2, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_union ?,?,?";//numero de parametros
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

        //---------------- Columnas de la diferencia de conjuntos  ----------------
        public ArrayList Columnas_diferencia(String BD, String tabla1, String tabla2)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_diferencia ?,?,?";//numero de parametros
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

                    columnas.Add(Contenedor["name"].ToString());


                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion de Diferencia conjuntos ----------------
        public ArrayList Operacion_diferencia(String BD, String tabla1, String tabla2, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_diferencia ?,?,?";//numero de parametros
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

        //---------------- Columnas de la interseccion ----------------
        public ArrayList Columnas_interseccion(String BD, String tabla1, String tabla2)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_interseccion ?,?,?";//numero de parametros
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

                    columnas.Add(Contenedor["name"].ToString());


                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion de interseccion ----------------
        public ArrayList Operacion_interseccion(String BD, String tabla1, String tabla2, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_interseccion ?,?,?";//numero de parametros
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

        //---------------- Columnas del Join ----------------
        public ArrayList Columnas_join(String BD, String tabla1, String tabla2, String predicado)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_join ?,?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(tabla2, 2);
            conexion.annadir_parametro(predicado, 2);

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

                    columnas.Add(Contenedor["name"].ToString());


                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion de Join ----------------
        public ArrayList Operacion_join(String BD, String tabla1, String tabla2, String predicado, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_join ?,?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(tabla2, 2);
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
                    int i = 0;
                    foreach (String columna in columnas)
                    {
                        atributos.Add(Contenedor[i].ToString());
                        i++;
                    }
                    tuplas.Add(atributos);
                    atributos = new ArrayList();

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }

        //---------------- Columnas del Natural Join ----------------
        public ArrayList Columnas_natural_join(String BD, String tabla1, String tabla2, String predicado)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_natural_join ?,?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(tabla2, 2);
            conexion.annadir_parametro(predicado, 2);

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
                    columnas.Add(Contenedor["name"].ToString());


                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion de natural Join ----------------
        public ArrayList Operacion_natural_join(String BD, String tabla1, String tabla2, String predicado, ArrayList columnas,String atributosPorMostrar)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_natural_join ?,?,?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(tabla2, 2);
            conexion.annadir_parametro(predicado, 2);
            conexion.annadir_parametro(atributosPorMostrar, 2);

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
                    int i = 0;
                    foreach (String columna in columnas)
                    {
                        atributos.Add(Contenedor[i].ToString());
                        i++;
                    }
                    tuplas.Add(atributos);
                    atributos = new ArrayList();

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }

        //---------------- Columnas de la agregacion ----------------
        public ArrayList Columnas_agregacion(String BD, String tabla1, String agregacion)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_agregacion ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(agregacion, 2);

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
                    columnas.Add(Contenedor["name"].ToString());
                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion de agregacion ----------------
        public ArrayList Operacion_agregacion(String BD, String tabla1, String agregacion, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_agregacion ?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(agregacion, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor == null)
            {
                tuplas = null;
                return tuplas;
            }
            else
            {
                int i = 0;
                //Buscar los campos solicitados
                while (Contenedor.Read())
                {
                    i = 0;
                    foreach (String columna in columnas)
                    {
                        atributos.Add(Contenedor[i].ToString());
                        i++;
                    }
                    tuplas.Add(atributos);
                    atributos = new ArrayList();

                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return tuplas;//devuelve los datos necesarios
            }
        }

        //---------------- Columnas de la agrupacion ----------------
        public ArrayList Columnas_agrupacion(String BD, String tabla1, String agrupacion, String agregacion)
        {
            ArrayList columnas = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Columnas_agrupacion ?,?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(agrupacion, 2);
            conexion.annadir_parametro(agregacion, 2);

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
                    columnas.Add(Contenedor["name"].ToString());
                }//CONTENEDOR READ

                Contenedor.Close();//Cierra contenedor con los datos seleccionados


                return columnas;//devuelve los datos necesarios
            }
        }

        //---------------- Operacion de Agrupacion ----------------
        public ArrayList Operacion_agrupacion(String BD, String tabla1, String agrupacion, String agregacion, ArrayList columnas)
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Operacion_agrupacion ?,?,?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla1, 2);
            conexion.annadir_parametro(agrupacion, 2);
            conexion.annadir_parametro(agregacion, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            if (Contenedor == null)
            {
                tuplas = null;
                return tuplas;
            }
            else
            {
                int i = 0;
                //Buscar los campos solicitados
                while (Contenedor.Read())
                {
                    i = 0;
                    foreach (String columna in columnas)
                    {
                        atributos.Add(Contenedor[i].ToString());
                        i++;
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
