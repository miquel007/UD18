using System;
using System.Data.SqlClient;

namespace UD18
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX_exemple();
            //EX1();
            //EX2();
            //EX3();
            //EX4();
            //EX5();
            //EX6();
            //EX7();
            //EX8();
            EX9();
        }

        public static void EX9()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database EX9";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable1
            SqlConnection conectDB = connect.getConnexionDB("EX9");
            connect = new connexio(conectDB);
            string cadena2 = "create table Facultad(codigo int Primary key identity(1,1), nombre  varchar(100) )";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable2
            connect = new connexio(conectDB);
            string cadena3 = "create table Investigadores(DNI varchar(8) Primary key, NomApels varchar(255), facultad int foreign key (facultad) references Facultad(codigo) )";
            crearTable tabla2 = new crearTable(cadena3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable3
            connect = new connexio(conectDB);
            string cadena4 = "create table Equipos(num_serie_eq char(4) Primary key, nombre varchar(100), facultad int foreign key (facultad) references Facultad(codigo) )";
            crearTable tabla3 = new crearTable(cadena4, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable4
            connect = new connexio(conectDB);
            string cadena5 = "create table Reserva(DNI varchar(8), num_serie char(4), Primary key(DNI,num_serie), comienzo datetime, fin datetime, foreign key (DNI) references Investigadores(DNI), foreign key (num_serie) references Equipos(num_serie_eq) )";
            crearTable tabla4 = new crearTable(cadena5, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla1
            connect = new connexio(conectDB);
            string valores1 = "insert into Facultad values('qwe'),('wer'),('ert'),('rty'),('tyu')";
            llenarTable llenar1 = new llenarTable(valores1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla2
            connect = new connexio(conectDB);
            string valores2 = "insert into Investigadores values('00999999','zxc',1),('11999999','xcv',2),('22999999','cvb',3),('33999999','vbn',4),('44999999','bnm',5) ";
            llenarTable llenar2 = new llenarTable(valores2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla3
            connect = new connexio(conectDB);
            string valores3 = "insert into Equipos values('1A','qaz',5),('2A','wsx',4),('3A','edc',3),('4A','rfv',2),('5A','tgb',1) ";
            llenarTable llenar3 = new llenarTable(valores3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla4
            connect = new connexio(conectDB);
            string valores4 = "insert into Reserva values('00999999','1A','2021-01-01','2021-01-02'),('11999999','2A','2021-01-01','2021-01-02'),('22999999','3A','2021-01-01','2021-01-02'),('33999999','4A','2021-01-01','2021-01-02'),('44999999','5A','2021-01-01','2021-01-02') ";
            llenarTable llenar4 = new llenarTable(valores4, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }
    
        public static void EX8()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database EX8";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable1
            SqlConnection conectDB = connect.getConnexionDB("EX8");
            connect = new connexio(conectDB);
            string cadena2 = "create table Cajeros(codigo int Primary key identity(1,1), nomApels  varchar(100) )";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable2
            connect = new connexio(conectDB);
            string cadena3 = "create table Productos(codigo int Primary key identity(1,1), nombre varchar(100), precio int )";
            crearTable tabla2 = new crearTable(cadena3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable3
            connect = new connexio(conectDB);
            string cadena4 = "create table Maquinas_Registradoras(codigo int Primary key identity(1,1), piso int )";
            crearTable tabla3 = new crearTable(cadena4, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable4
            connect = new connexio(conectDB);
            string cadena5 = "create table Venta(cajero int, maquina int, producto int, Primary key(cajero,maquina,producto), foreign key (cajero) references Cajeros(codigo), foreign key (maquina) references Maquinas_Registradoras(codigo), foreign key (producto) references Productos(codigo) )";
            crearTable tabla4 = new crearTable(cadena5, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla1
            connect = new connexio(conectDB);
            string valores1 = "insert into Cajeros values('1A'),('2A'),('3A'),('4A'),('5A')";
            llenarTable llenar1 = new llenarTable(valores1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla2
            connect = new connexio(conectDB);
            string valores2 = "insert into Productos values('qwe',1),('wer',2),('ert',3),('ert',4),('rty',5) ";
            llenarTable llenar2 = new llenarTable(valores2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla3
            connect = new connexio(conectDB);
            string valores3 = "insert into Maquinas_Registradoras values(11),(12),(13),(14),(15) ";
            llenarTable llenar3 = new llenarTable(valores3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla4
            connect = new connexio(conectDB);
            string valores4 = "insert into Venta values(1,2,3),(2,3,4),(3,4,5),(4,5,1),(5,1,2) ";
            llenarTable llenar4 = new llenarTable(valores4, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }

        public static void EX7()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database EX7";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable1
            SqlConnection conectDB = connect.getConnexionDB("EX7");
            connect = new connexio(conectDB);
            string cadena2 = "create table Proyecto(id char(4) Primary key, nombre varchar(100), horas int )";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable2
            connect = new connexio(conectDB);
            string cadena3 = "create table Cientificos(DNI varchar(8) Primary key, nomApels varchar(255) )";
            crearTable tabla2 = new crearTable(cadena3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable3
            connect = new connexio(conectDB);
            string cadena4 = "create table Suministra(cientifico varchar(8), proyecto char(4), Primary key(cientifico,proyecto), foreign key (cientifico) references Cientificos(DNI), foreign key (proyecto) references Proyecto(id) )";
            crearTable tabla3 = new crearTable(cadena4, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla1
            connect = new connexio(conectDB);
            string valores1 = "insert into Proyecto values('1A','rau',1),('2A','qwe',2),('3A','ert',3),('4A','tyu',4),('5A','yui',5)";
            llenarTable llenar1 = new llenarTable(valores1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla2
            connect = new connexio(conectDB);
            string valores2 = "insert into Cientificos values('58999999','POLI'),('49999999','POLI'),('30999999','POLI'),('21999999','POLI'),('32999999','POLI') ";
            llenarTable llenar2 = new llenarTable(valores2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla3
            connect = new connexio(conectDB);
            string valores3 = "insert into Suministra values('58999999','1A'),('49999999','2A'),('30999999','3A'),('21999999','4A'),('32999999','5A')";
            llenarTable llenar3 = new llenarTable(valores3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }

        public static void EX6()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database EX6";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable1
            SqlConnection conectDB = connect.getConnexionDB("EX6");
            connect = new connexio(conectDB);
            string cadena2 = "create table Piezas(codigo int Primary key identity(1,1), nombre varchar(100) )";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable2
            connect = new connexio(conectDB);
            string cadena3 = "create table Proveedores(id char(4) Primary key, nombre varchar(100) )";
            crearTable tabla2 = new crearTable(cadena3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable3
            connect = new connexio(conectDB);
            string cadena4 = "create table Suministra(cod_pieza int, id_proveedor char(4), Primary key(cod_pieza,id_proveedor), precio int, foreign key (cod_pieza) references Piezas(codigo), foreign key (id_proveedor) references Proveedores(id) )";
            crearTable tabla3 = new crearTable(cadena4, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla1
            connect = new connexio(conectDB);
            string valores1 = "insert into Piezas values('Rali'),('Poli'),('Manc'),('Rit'),('Exec')";
            llenarTable llenar1 = new llenarTable(valores1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla2
            connect = new connexio(conectDB);
            string valores2 = "insert into Proveedores values('1A','Pol'),('2A','Loi'),('3A','Iok'),('4A','Kou'),('5A','Uyh')";
            llenarTable llenar2 = new llenarTable(valores2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla3
            connect = new connexio(conectDB);
            string valores3 = "insert into Suministra values(1,'3A',34),(2,'4A',35),(3,'5A',36),(4,'1A',37),(5,'2A',38)";
            llenarTable llenar3 = new llenarTable(valores3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }

        public static void EX5()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database EX5";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable1
            SqlConnection conectDB = connect.getConnexionDB("EX5");
            connect = new connexio(conectDB);
            string cadena2 = "create table Despachos(num int Primary key identity(1,1), capacidad int)";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable2
            connect = new connexio(conectDB);
            string cadena3 = "create table Directores(DNI varchar(8) Primary key, nomApels varchar(255), despacho int, foreign key (despacho) references Despachos(num), DNIjefe varchar(8) foreign key (DNIjefe) references Directores(DNI) )";
            crearTable tabla2 = new crearTable(cadena3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla1
            connect = new connexio(conectDB);
            string valores1 = "insert into Despachos values(34),(45),(67),(32),(34)";
            llenarTable llenar1 = new llenarTable(valores1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla2
            connect = new connexio(conectDB);
            string valores2 = "insert into Directores values('67999999','POLI',1,null),('58999999','POLI',1,'67999999'),('49999999','POLI',5,'67999999'), ('69999999','POLI',3,'58999999'),('78999999','POLI',4,'58999999')";
            llenarTable llenar2 = new llenarTable(valores2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }

        public static void EX4()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database EX4";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable1
            SqlConnection conectDB = connect.getConnexionDB("EX4");
            connect = new connexio(conectDB);
            string cadena2 = "create table Peliculas(codigo int Primary key identity(1,1), nombre varchar(100) null, edad varchar(100))";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable2
            connect = new connexio(conectDB);
            string cadena3 = "create table Salas(codigo int Primary key identity(1,1), nombre varchar(100), pelicula int foreign key (pelicula) references Peliculas(codigo) )";
            crearTable tabla2 = new crearTable(cadena3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla1
            connect = new connexio(conectDB);
            string valores1 = "insert into Peliculas values('Citizen Kane', 'PG'), ('Singin in the Rain', 'G'), ('The Wizard of Oz', 'G'), ('The Quiet Man', NULL), ('North by Northwest', NULL)";
            llenarTable llenar1 = new llenarTable(valores1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla2
            connect = new connexio(conectDB);
            string valores2 = "insert into Salas values('Odeon', 5), ('Imperial', 1), ('Majestic', NULL), ('Paraiso', 3), ('Nickelodeon', NULL)";
            llenarTable llenar2 = new llenarTable(valores2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }

        public static void EX3()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database EX3";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable1
            SqlConnection conectDB = connect.getConnexionDB("EX3");
            connect = new connexio(conectDB);
            string cadena2 = "create table Almacenes(codigo int Primary key identity(1,1), lugar varchar(100) null, capacidad int)";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable2
            connect = new connexio(conectDB);
            string cadena3 = "create table Cajas(num_referencia char(5), contenido varchar(100), valor int, cod_almacen int foreign key (cod_almacen) references Almacenes(codigo) )";
            crearTable tabla2 = new crearTable(cadena3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla1
            connect = new connexio(conectDB);
            string valores1 = "insert into Almacenes values('Valencia', 3), ('Barcelona', 4), ('Bilbao', 7), ('Los Angeles', 2), ('San Francisco', 8)";
            llenarTable llenar1 = new llenarTable(valores1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla2
            connect = new connexio(conectDB);
            string valores2 = "insert into Cajas values('0MN7', 'Rocks', 180, 3), ('4H8P', 'Rocks', 250, 1), ('4RT3', 'Scissors', 190, 4), ('7G3H', 'Rocks', 200 , 1), ('8JN6', 'Papers', 75, 1)";
            llenarTable llenar2 = new llenarTable(valores2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }

        public static void EX2()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database EX2";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable1
            SqlConnection conectDB = connect.getConnexionDB("EX2");
            connect = new connexio(conectDB);
            string cadena2 = "create table Departamentos(codigo int Primary key, nombre varchar(100) null, presupuesto int)";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable2
            connect = new connexio(conectDB);
            string cadena3 = "create table Empleados(DNI varchar(8) Primary key, nombre varchar(100) null, apellidos varchar(255), cod_departamento int foreign key (cod_departamento) references Departamentos(codigo))";
            crearTable tabla2 = new crearTable(cadena3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla1
            connect = new connexio(conectDB);
            string valores1 = "insert into Departamentos values(14, 'IT', 65000), (37, 'Accounting', 15000), ( 59, 'Human Resources', 24000 ), (77, 'Research', 24000), (69, 'Research', 55000)";
            llenarTable llenar1 = new llenarTable(valores1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla2
            connect = new connexio(conectDB);
            string valores2 = "insert into Empleados values('12323487', 'Michael', 'Rogers', 14), ('15293448', 'Anand', 'Manikutty', 14), ('33256943', 'George', 'ODonnell', 77), ('36587417', 'Joe', 'Stevens', 37), ('65483219', 'Zacary', 'Efron', 59)";
            llenarTable llenar2 = new llenarTable(valores2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }

        public static void EX1()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database EX1";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable1
            SqlConnection conectDB = connect.getConnexionDB("EX1");
            connect = new connexio(conectDB);
            string cadena2 = "create table fabricantes(codigo int Primary key identity(1,1), nombre varchar(100) null)";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable2
            connect = new connexio(conectDB);
            string cadena3 = "create table articulos(codigo int Primary key identity(1,1), nombre varchar(100) null, precio int, cod_fabricante int foreign key (cod_fabricante) references fabricantes(codigo) )";
            crearTable tabla2 = new crearTable(cadena3, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla1
            connect = new connexio(conectDB);
            string valores1 = "insert into fabricantes values('Sony'), ('CreativeLabs'), ('HewlettPackard'), ('Iomega'), ('Fujitsu')";
            llenarTable llenar1 = new llenarTable(valores1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla2
            connect = new connexio(conectDB);
            string valores2 = "insert into articulos values('Hard drive', 240, 5),('Monitor', 240, 1), ('DVD drive', 180, 2), ('CD drive', 90, 2), ('Toner cartridge', 66, 3)";
            llenarTable llenar2 = new llenarTable(valores2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }
        
        public static void EX_exemple()
        {
            //crearDB
            connexio connect = connect = new connexio(); ;
            descoconnexio desconnect;
            string cadena1 = "create database db_exemple";
            crearDB base1 = new crearDB(cadena1, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //crearTable
            SqlConnection conectDB = connect.getConnexionDB("db_exemple");
            connect = new connexio(conectDB);
            string cadena2 = "create table tabla1(id int primary key, nom varchar(10) null, apellido varchar(10) null)";
            crearTable tabla1 = new crearTable(cadena2, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
            //llenarTabla
            connect = new connexio(conectDB);
            string valores = "insert into tabla1 values(4,'Luis','Machado')";
            llenarTable llenar1 = new llenarTable(valores, connect.getConnexion());
            desconnect = new descoconnexio(connect.getConnexion());
        }
    }
}
