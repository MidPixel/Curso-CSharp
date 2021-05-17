

//determinando um Enum, cria-se como uma Classe, mas o tipo é trocado para enum, logo após é colocado os ":" para depois determinar o derivado
//Sintaxe: enum <Nome da Classe> : <Tipo do Enum>

namespace Proj001___Enum.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
