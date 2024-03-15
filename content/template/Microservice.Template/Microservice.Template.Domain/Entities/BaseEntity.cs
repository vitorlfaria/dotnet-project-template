namespace Microservice.Template.Domain;

public class BaseEntity
{
    public int CodigoId { get; private set; }
    public DateTime CriadoEm { get; private set; }
    public DateTime? AtualizadoEm { get; private set; }
    public DateTime? DeletadoEm { get; private set; }
    public bool StatusAtivo { get; private set; }
 
    public BaseEntity(int codigoId, DateTime criadoEm, DateTime? atualizadoEm, DateTime? deletadoEm, bool statusAtivo)
    {
        CodigoId = codigoId;
        CriadoEm = criadoEm;
        AtualizadoEm = atualizadoEm;
        DeletadoEm = deletadoEm;
        StatusAtivo = statusAtivo;
    }
}
