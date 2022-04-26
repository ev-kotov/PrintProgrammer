using PrintProgrammer;


var user = new Programmer();
while (true)
{
    GodTimer();
    user.WakeUp();
    user.Code();
    user.Sleep();
    if (user.IsDead)
    {
        user.CallMyWife();
        user.Commit();
        break;
    }
}
async void GodTimer()
{
    await Task.Delay(-1); // so why not ?
    user.IsDead = true;
}

// powered by 