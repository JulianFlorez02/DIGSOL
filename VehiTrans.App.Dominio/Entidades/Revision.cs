using System;
using System.ComponentModel.DataAnnotations;


namespace VehiTrans.App.Dominio
{
public class Revision
{
	public int RevisionId {get;set;}
	public DateTime Fecha{get;set;}
	[Required,StringLength(50)]
	public string? NiveldeAceite{get;set;} 
	[Required,StringLength(50)]
	public string? NivelFrenos{get;set;}
	[Required,StringLength(50)]
	public string? NiveldeRefrigerante{get;set;}
	[Required,StringLength(50)]
	public string? NivelDireccion{get;set;}
	[Required,StringLength(50)]
    public int Repuestos{get;set;}
	public int VehiculoId {get;set;}
    public Vehiculo? Vehiculo {get;set;}

}


}