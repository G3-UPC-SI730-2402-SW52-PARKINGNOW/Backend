using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace backend.User.Domain.Model.Aggregates;

public class UsuarioAudit : IEntityWithCreatedUpdatedDate
{
    [Column("CreatedAt")] 
    public DateTimeOffset? CreatedDate { get; set; }
    
    [Column("UpdatedAt")]
    public DateTimeOffset? UpdatedDate { get; set; }
}