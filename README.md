Materi docker ini untuk RAY talk tanggal 24 mei 2019

Pembahasan step-02 docker port binding

a. Basic Port Binding
```bash
docker run -d --name mariadb_containier -p 50001:3306 -e MYSQL_ROOT_PASSWORD=mypassword mariadb
```

b. Create Multi Container With Same Port on Container
```bash
docker run -d --name mariadb_containier_1 -p 50001:3306 -e MYSQL_ROOT_PASSWORD=mypassword mariadb
docker run -d --name mariadb_containier_2 -p 50001:3306 -e MYSQL_ROOT_PASSWORD=mypassword mariadb
```
