﻿

namespace DO;
///There are tasks that depend on the previous task to which the dependency applies this
public record Dependence
(
    int Id,
    int DependentOnTask,///A previous task  
    int DependentTask///A task that cannot be performed without the DependentOnTask-previous task
);
