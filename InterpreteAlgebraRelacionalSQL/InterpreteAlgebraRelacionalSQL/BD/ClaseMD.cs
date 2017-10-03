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

            return Resultado;//devolvuelve los datos necesarios
        }

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

            return Resultado;//devolvuelve los datos necesarios
        }

        public ArrayList select_NombreColumnas(String BD, String tabla)
        {
            ArrayList columnas=new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos

            consulta = "EXEC Nombre_Columnas ?,?";//numero de parametros
            conexion.annadir_consulta(consulta);
            conexion.annadir_parametro(BD, 2);
            conexion.annadir_parametro(tabla, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            //Buscar los campos solicitados
            while (Contenedor.Read())
            {               
                columnas.Add(Contenedor["COLUMN_NAME"].ToString());
            }//CONTENEDOR READ

            Contenedor.Close();//Cierra contenedor con los datos seleccionados

            return columnas;//devolvuelve los datos necesarios
        }

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

            //Buscar los campos solicitados
            while (Contenedor.Read())
            {
                foreach(String columna in columnas){
                    atributos.Add(Contenedor[columna.ToString()].ToString());
                }
                tuplas.Add(atributos);
                atributos=new ArrayList();
                
            }//CONTENEDOR READ

            Contenedor.Close();//Cierra contenedor con los datos seleccionados

           
            return tuplas;//devolvuelve los datos necesarios
        }
    }
}
