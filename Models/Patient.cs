using Lab2_EF.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2_EF.Models;

[Table("patient", Schema = "public")]
public partial class Patient
{
    [Key]
    [Required(ErrorMessage = "СНИЛС обязателен")]
    [MaxLength(14)]
    [Column("snils")]
    public string Snils { get; set; } = null!;

    [Required(ErrorMessage = "ФИО обязательно")]
    [MaxLength(70)]
    [Column("fio")]
    public string Fio { get; set; } = null!;

    [MaxLength(1)]
    [Column("pol")]
    public string? Pol { get; set; }

    [Column("birthdate")]
    public DateOnly? Birthdate { get; set; }

    [Column("card_num")]
    [MaxLength(255)]
    public string? CardNum { get; set; }

    [Column("polis")]
    public long? Polis { get; set; }

    [Column("workplace")]
    [MaxLength(255)]
    public string? Workplace { get; set; }

    [Column("streetid")]
    public int? Streetid { get; set; }

    [Column("house_num")]
    [MaxLength(15)]
    public string? HouseNum { get; set; }

    [Column("flat_num")]
    [MaxLength(7)]
    public string? FlatNum { get; set; }
    //[NotMapped]
    //public string ShortInfo => $"{Fio} (СНИЛС: {Snils})";

    [ForeignKey("Streetid")]
    public virtual Street? Street { get; set; }

    public virtual ICollection<Visitschedule> Visitschedules { get; set; } = new List<Visitschedule>();
    //public virtual ICollection<Caseof> Caseofs { get; set; } = new List<Caseof>();
}
