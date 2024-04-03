using WebAPIFuncionarios.Models;

namespace WebAPIFuncionarios.Services;

public interface IFuncionarioInterface
{
    Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionario();
    Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
    Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);
    Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
    Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);
    Task<ServiceResponse<List<FuncionarioModel>>> InativarFuncionario(int id);
    

}