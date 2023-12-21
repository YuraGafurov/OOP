using Itmo.ObjectOrientedProgramming.Lab4.Entities.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Commands.FileMove;
using Itmo.ObjectOrientedProgramming.Lab4.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Handlers.CommandHandlers;

public class FileMoveHandler : BaseHandler
{
    public override ICommand? Handle(Iterator request)
    {
        string tmpRequest = request.Current() + " ";
        if (!request.MoveNext()) return base.Handle(request);
        tmpRequest += request.Current();
        if (tmpRequest is not "file move" || !request.MoveNext()) return base.Handle(request);

        string sourcePath = request.Current();
        if (!request.MoveNext()) return base.Handle(request);
        string destinationPath = request.Current();

        return new FileMove(sourcePath, destinationPath);
    }
}