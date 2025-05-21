
PPROJECT:
- Am creat clasele din Models (User.cs, Post.cs, Account.cs, ChatNotification.cs, LikeNotification.cs, ISendNotification.cs)
- ISendNotification.cs este o interfata pentru a trimite notificari de primire mesaj (ChatNotification.cs) si primire like (LikeNotification.cs)
- Account.cs este o clasa abstracta care contine functia de creare cont
- User.cs foloseste abstractizarea pentru crearea contului
- Am creat clasele din ModelDTOs (PostDTO.cs, UserDTO.cs)
- Am creat clasele din Implementations (UserService.cs, PostService.cs)
- Am creat clasele din Interfaces (IUserService.cs, IPostService.cs)
- IUserService.cs contine interfata pentru UserService.cs
- IPostService.cs contine interfata pentru PostService.cs
- Am creat controllerele (UserController.cs, PostController.cs)
- Am realizar migrarile pentru baza de date si am facut update bazei pentru migrari
- Am editat fisierul setup.txt pentru instructiunile de setup
- Am editat fisierul README.txt cu informatiile despre ce am realizat in proiect