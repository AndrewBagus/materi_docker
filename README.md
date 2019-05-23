Materi docker ini untuk RAY talk tanggal 24 mei 2019

Pembahasan step-03 docker volume

a. Docker Volume List
```bash
docker volume ls
```

b. Docker create volume
```bash
docker volume create dbvol
```

c. Binding Volume to Container
```bash
docker run -d --name mariadb_containier_1 -v dbvol:/var/lib/mysql -p 50001:3306 -e MYSQL_ROOT_PASSWORD=mypassword mariadb
docker run -d --name mariadb_containier_2 -p /home/mawmaw/Kerja/Db/dockerdb/mariadb_docker 50001:3306 -e MYSQL_ROOT_PASSWORD=mypassword mariadb
```
d. Docker Volume Remove All
```bash
docker volume prune
```
