# INCLUDE <ISOSTREM>
# INCLUDE <STRING>
# INCLUDE <VECTOR>
# INCLUDE <MEMORY>
//1. Clase Centro de Trabajo class CentroDeTRABAJO { public:
int numeroCentro;
std:: string cuidad;
std:: string NombreCentro;
CentroDeTrabajo (int id, std :: string city, std :: string name):  numeroCentro;(id), cuidad (city), 
    nombreCentro(name) {} };
// 2. Clase Puesto class Puesto { public:
int numeroPuesto;
sdt :: string nombrePuesto;
std :: string direccionDepartamento;
puesto(int id, std : : string name, std : : string dept) : numeroPuesto (id),
    nombrePuesto(name), 
    direccionDepartamento(dept) { } };
// 3. Clase Empleado (Base) class Empleado { public: 
int numeroEmpleado;
std:: string nombre;
std:: string apellidoPaterno;
std:: string apellidoMaterno;
std:: string fechaNacimiento;
std:: string rfc;
//Relacion (Punteros a los objetos relacionados) CentroDeTrabajo* centroPuesto* puesto;
bool esDirectivo;
numeroEmpleado(indexer id, std: : string nom, std:: string apeP, std:: string rfcVal, CentroDeTrabajo* c, Puesto* p)
    : numeroEmpleado (id), nombre(nom), apellidoPaterno(apeP), rec(rfcval), 
    centro (c), puesto(p), esDirectivo(false){ }}
// 4.Clase Directivo (Ezpecializacion/herencia)
// Representa la tabla Directivo_INFO vinculada a EMPLEADO class Directivo : public Eempleado {
public: 
    int numeroCentroSupervisa;
double prestacionCombustible;
Directivo(int id, std:: string nom, std:: string apeP, std:: string rcfVal, CentroDeTrabajo* c,
   puesto p*, int centroSup, double combustible) 
    : Empleado (id, nom, apeP, recVal, c, p ), 
    numeroCentroSupervisa(centroSup), prestacionCombustible(combustible) }
    };
int main() {
    //ejemplo de uso:
    //crear Catalogos 
    CentroDeTrabajo centro1(¨Tienda ANGEL FLORES ROPA¨);
    Puesto puesto1(501, Vendedor ¨primera caja¨), nombre (Jesus), apellidoPaterno(Vega), apellidoMaterno(castro),
        fechaNacimiento (26/03/1998), rfc(VECJ880326XXX), numeroEmpleado(902805)};
// crear catalogos
nombre(Jose), apellidoPaterno(Lopez), apellidoMaterno(Perez),fechaNacimiento(01/01/1980), ref(LOPJ800101XXX),
    CentroDeTrabajo(tienda ANGELES FLORES CAJAS), puesto piesto1(gerente esDirectivo), numeroEmplado(90252806)
