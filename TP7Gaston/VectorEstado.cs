using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class VectorEstado
    {
        private int linea;
        private String evento;
        private double reloj;
        private double rndLlegadaCliente;
        private double tiempoLlegadaCliente;
        private double proximaLlegadaCliente;
        private double rndMayorEdad;
        private int esMayorEdad;
        private double rndEdad;
        private int edad;
        private double rndFinHacerEntender;
        private double tiempoFinHacerEntender;
        //el proximo fin de hacer entender de cada dependiente estan como atributo en el respectivo dependiente
        private double tiempoProximaTarea;
        private double proximaTarea;
        private double rndDependienteTarea;
        private int dependienteTarea;
        //las tareas del dependiente están como atributo en cada dependiente
        private double rndFinOtraTarea;
        private double tiempoFinOtraTarea;
        //el proximo fin de otra tarea de cada dependiente esta como atributo en cada dependiente
        private Dependiente[] dependientes = new Dependiente[3];
        private Queue<Cliente> colaAtencion;
        private double gradoOcupacionDependiente1;
        private double gradoOcupacionDependiente2;
        private double gradoOcupacionDependiente3;
        private double esperaPromedioCola;
        private int cantidadPersonasAtendidas;
        private double porcentajeClientesAtendidosMayoresEdad;
        private double porcentajeOcupacionIrrelevante1;
        private double porcentajeOcupacionIrrelevante2;
        private double porcentajeOcupacionIrrelevante3;
        private double tiempoMaximoPermanenciaSistemaMayorEdad;
        private double acTiempoOcupacion1;
        private double acTiempoOcupacion2;
        private double acTiempoOcupacion3;
        private double acTiempoEspera;
        private int acClientesCola;
        private int acPersonasAtendidasMayoresEdad;
        private double acTiempoOcupacionIrrelevante1;
        private double acTiempoOcupacionIrrelevante2;
        private double acTiempoOcupacionIrrelevante3;
        private double acClientesAtendidos;

        public int Linea { get => linea; set => linea = value; }
        public string Evento { get => evento; set => evento = value; }
        public double Reloj { get => reloj; set => reloj = value; }
        public double RndLlegadaCliente { get => rndLlegadaCliente; set => rndLlegadaCliente = value; }
        public double TiempoLlegadaCliente { get => tiempoLlegadaCliente; set => tiempoLlegadaCliente = value; }
        public double ProximaLlegadaCliente { get => proximaLlegadaCliente; set => proximaLlegadaCliente = value; }
        public double RndMayorEdad { get => rndMayorEdad; set => rndMayorEdad = value; }
        public int EsMayorEdad { get => esMayorEdad; set => esMayorEdad = value; }
        public double RndEdad { get => rndEdad; set => rndEdad = value; }
        public int Edad { get => edad; set => edad = value; }
        public double RndFinHacerEntender { get => rndFinHacerEntender; set => rndFinHacerEntender = value; }
        public double TiempoFinHacerEntender { get => tiempoFinHacerEntender; set => tiempoFinHacerEntender = value; }
        public double TiempoProximaTarea { get => tiempoProximaTarea; set => tiempoProximaTarea = value; }
        public double ProximaTarea { get => proximaTarea; set => proximaTarea = value; }
        public double RndDependienteTarea { get => rndDependienteTarea; set => rndDependienteTarea = value; }
        public int DependienteTarea { get => dependienteTarea; set => dependienteTarea = value; }
        public double RndFinOtraTarea { get => rndFinOtraTarea; set => rndFinOtraTarea = value; }
        public double TiempoFinOtraTarea { get => tiempoFinOtraTarea; set => tiempoFinOtraTarea = value; }
        public Dependiente[] Dependientes { get => dependientes; set => dependientes = value; }
        public Queue<Cliente> ColaAtencion { get => colaAtencion; set => colaAtencion = value; }
        public double GradoOcupacionDependiente1 { get => gradoOcupacionDependiente1; set => gradoOcupacionDependiente1 = value; }
        public double GradoOcupacionDependiente2 { get => gradoOcupacionDependiente2; set => gradoOcupacionDependiente2 = value; }
        public double GradoOcupacionDependiente3 { get => gradoOcupacionDependiente3; set => gradoOcupacionDependiente3 = value; }
        public double EsperaPromedioCola { get => esperaPromedioCola; set => esperaPromedioCola = value; }
        public int CantidadPersonasAtendidas { get => cantidadPersonasAtendidas; set => cantidadPersonasAtendidas = value; }
        public double PorcentajeClientesAtendidosMayoresEdad { get => porcentajeClientesAtendidosMayoresEdad; set => porcentajeClientesAtendidosMayoresEdad = value; }
        public double PorcentajeOcupacionIrrelevante1 { get => porcentajeOcupacionIrrelevante1; set => porcentajeOcupacionIrrelevante1 = value; }
        public double PorcentajeOcupacionIrrelevante2 { get => porcentajeOcupacionIrrelevante2; set => porcentajeOcupacionIrrelevante2 = value; }
        public double PorcentajeOcupacionIrrelevante3 { get => porcentajeOcupacionIrrelevante3; set => porcentajeOcupacionIrrelevante3 = value; }
        public double TiempoMaximoPermanenciaSistemaMayorEdad { get => tiempoMaximoPermanenciaSistemaMayorEdad; set => tiempoMaximoPermanenciaSistemaMayorEdad = value; }
        public double AcTiempoOcupacion1 { get => acTiempoOcupacion1; set => acTiempoOcupacion1 = value; }
        public double AcTiempoOcupacion2 { get => acTiempoOcupacion2; set => acTiempoOcupacion2 = value; }
        public double AcTiempoOcupacion3 { get => acTiempoOcupacion3; set => acTiempoOcupacion3 = value; }
        public double AcTiempoEspera { get => acTiempoEspera; set => acTiempoEspera = value; }
        public int AcClientesCola { get => acClientesCola; set => acClientesCola = value; }
        public int AcPersonasAtendidasMayoresEdad { get => acPersonasAtendidasMayoresEdad; set => acPersonasAtendidasMayoresEdad = value; }
        public double AcTiempoOcupacionIrrelevante1 { get => acTiempoOcupacionIrrelevante1; set => acTiempoOcupacionIrrelevante1 = value; }
        public double AcTiempoOcupacionIrrelevante2 { get => acTiempoOcupacionIrrelevante2; set => acTiempoOcupacionIrrelevante2 = value; }
        public double AcTiempoOcupacionIrrelevante3 { get => acTiempoOcupacionIrrelevante3; set => acTiempoOcupacionIrrelevante3 = value; }
        public double AcClientesAtendidos { get => acClientesAtendidos; set => acClientesAtendidos = value; }
    }
}
