Materi docker ini untuk RAY talk tanggal 26 mei 2019 (update)

Pembahasan step-09 setup asp.net connect with mariadb via network

Create docker network
```bash
docker network create db
```

Create and run mysql
```bash
docker run -d -p 50001:3306 --name=sql -e MYSQL_ROOT_PASSWORD=mypassword --network=db mariadb
```

Install docker extention for vs code

add Docker: Launch .NET core (Preview) at vscode debugger

Change launch.json
```bash
"dockerRun": {
               "ports": [{
                   "containerPort": "80",
                   "hostPort": "51234"
               }],
               "network": "db"
           }
```

Run from vscode with f5

