
using System;

namespace mysqlConnect
{ 
	class Program
	{
		public static void Main (string[] args)
			{   
				
				int op=0;
			
				do{
					 
				Console.WriteLine("-------------------------------------------------" );	
				Console.WriteLine("\n "  );
				Console.WriteLine("        Menu");
				Console.WriteLine("(1)Mostrar profesores");
				Console.WriteLine("(2)Agregar profesor");
				Console.WriteLine("(3)Editar Codigo del profesor");
				Console.WriteLine("(4)Editar nombre del profesor");
				Console.WriteLine("(5)Eliminar profesor");
				Console.WriteLine("(6)Salir");
			    Console.WriteLine("Opcion :");
				
			
			
			    op=Convert.ToInt16(Console.ReadLine());
				
				profesor profesores1 = new profesor();
				switch(op){
							
			    case 1: 
				Console.WriteLine("\n "  );
				Console.WriteLine("Profesores registrados:");
				profesores1.mostrarTodosp();
				break;
					
				
				case 2:
				Console.WriteLine("\n "  );
				Console.WriteLine("          Agregar profesor");
				profesores1.insertarRegistroNuevop();
				Console.WriteLine("\n "  );
				Console.WriteLine("Datos registrados:");
				Console.WriteLine("Profesores registrados:");
				profesores1.mostrarTodosp();
				
				break;
				 
				 
			    case 3:
				Console.WriteLine("\n "  );
				Console.WriteLine("          Editar Codigo profesor");
			    profesores1.editarCodigoRegistrop();
				Console.WriteLine("\n "  );
				Console.WriteLine("Datos registrados:");
				profesores1.mostrarTodosp();
				
				break;
				
				
				case 4:
				Console.WriteLine("\n "  );
				Console.WriteLine("     Editar Nombre profesor");
				profesores1.editarNombreRegistrop();
				Console.WriteLine("\n "  );
				Console.WriteLine("Datos registrados:");
				profesores1.mostrarTodosp();
				
				break;
					
				
				case 5:
				
				Console.WriteLine("\n "  );
				Console.WriteLine("         Eliminar profesor");
				profesores1.eliminarRegistroPorIdp();
				Console.WriteLine("\n "  );
				Console.WriteLine("Datos registrados:");
				profesores1.mostrarTodosp();
				break;
				
				
			  
			    
			  
				}
				
				}while(op !=6);
			
			
		
			Console.Read();
		}
	}
}