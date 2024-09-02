using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerAPI.Models;

public class Vehiculo
{
    [Key]
    public int Id { get; set; }
    public required string Marca { get; set; }
    public required string Modelo { get; set; }
    public required int Año { get; set; }
    public required string Color { get; set; }
    public string TipoVehiculo { get; set; }
    public required int PropietarioId { get; set; }

    // Enlaces foraneos
    [ForeignKey("PropietarioId")]
    public Propietario? Propietario { get; set; }
}
