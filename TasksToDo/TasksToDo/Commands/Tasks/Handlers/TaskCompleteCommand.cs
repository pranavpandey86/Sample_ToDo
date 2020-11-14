﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TasksToDo.Commands.Tasks.Handlers
{
    public class TaskCompleteCommand : SingleEntityCommandBase, IRequest<CommandResult>
    {
    }
}
