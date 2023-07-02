using System;
class Empleado{
	public Empleado(string nombre, string apellido, int edad, double tarifa){
		this.nombre = nombre;
		this.apellido = apellido;
 		this.edad = edad;
		this.tarifa = tarifa;
	}
	protected string nombre;
	protected string apellido;
	protected int edad;
	protected double tarifa;
	public virtual double CalcularPaga(int horasTrabajadas){
		return(tarifa*(double)horasTrabajadas);
	}
}
class EmpleadoContrato : Empleado {
    public EmpleadoContrato(String nombre, string apellido, int edad, double tarifa)
    : base(nombre,apellido,edad,tarifa) {}
    public override double CalcularPaga(int horasTrabajadas){
        Console.WriteLine("EmpleadoContrato.CalcularPaga");
        return 42; //Valor Imaginario
    }
}
class EmpleadoSalariado : Empleado {
    public EmpleadoSalariado(String nombre,string apellido,int edad,double tarifa)
    : base(nombre,apellido,edad,tarifa){}
    public override double CalcularPaga(int horasTrabajadas){
        Console.WriteLine("EmpleadoSalariado.CalcularPaga");
        return 44; //Valor Imaginario
    }
}
class EmpleadoPorHora : Empleado {
    public EmpleadoPorHora(string nombre,string apellido,int edad,double tarifa)
    : base(nombre,apellido,edad,tarifa){}
    public override double CalcularPaga(int horasTrabajadas){
        Console.WriteLine("EmpleadoPorHora.CalcularPaga");
        return 38;
    }
}
class pagoApp{
    protected Empleado[] empleados;
    protected void CargarEmpleados(){
        Console.WriteLine("Cargando empleados...");
        //En una aplicacion posible leeriamos esto
        empleados = new Empleado[3];
        empleados[0] = new EmpleadoContrato("Amy","Anderson",28,100);
        empleados[1] = new EmpleadoSalariado("John","Ota",35,110);
        empleados[2] = new EmpleadoPorHora("Carlos","Smith",27,90);
        Console.WriteLine("\n");
    }
    protected void CalcularPaga(){
        foreach(Empleado emp in empleados){
            emp.CalcularPaga(40);
        }
    }
    public static void Main(){
        pagoApp app = new pagoApp();
        app.CargarEmpleados();
        app.CalcularPaga();
    }
}
