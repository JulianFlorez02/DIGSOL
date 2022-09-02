using System;
using System.ComponentModel.DataAnnotations;


namespace VehiTrans.App.Dominio
{
public class Revision :Vehiculo
{
	public int idRevision{get;set;}
	public date Fecha{get;set;}
	public String NiveldeAceite{get;set;} 
	public String NivelFrenos{get;set;}
	public String NiveldeRefrigerante{get;set;}
	public String NivelDireccion{get;set;}
    public int Repuestos{get;set;}
    public Vehiculo vehiculo_idvehiculo{get;set;}

}


}