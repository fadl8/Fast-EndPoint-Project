class UserEndPoint : EndpointWithoutRequest<User>
{
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();        
    }

    public override void OnBeforeHandle(EmptyRequest req)
    {
        base.OnBeforeHandle(req);
    }

    public override void OnAfterHandle(EmptyRequest req, User res)
    {
        base.OnAfterHandle(req, res);
    }

    public override Task HandleAsync(CancellationToken ct)
    {
        return base.HandleAsync(ct);    
    }
}