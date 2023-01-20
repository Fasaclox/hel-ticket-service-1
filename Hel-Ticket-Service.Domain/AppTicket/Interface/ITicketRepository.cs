namespace Hel_Ticket_Service.Domain;

public interface ITicketRepository{
    // #region Cache
    // Task<Ticket> SaveTicketToCache(Ticket ticket);
    // Task<Ticket> GetTicketFromCache(string reference);
    // #endregion

    #region Database
    Task<string> CreateTicket(CreateTicketDto ticket);
    Task<string> UpdateTicket(string reference, UpdateTicketDto ticket);
    Task<string> DeleteTicket(string reference);
    Task<Ticket> GetTicketByReference(string reference);
    
    #endregion
}

