namespace ExpenseTracker.Core.Dto.Workspace
{
    public class WorkspaceCreateDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string? Description { get; set; }
        
    }
}