Materi docker ini untuk RAY talk tanggal 24 mei 2019

Pembahasan step-05 asp.net core running on docker

Build Dockerfile to Docker Image
```bash
docker build -t webapi:latest .
```

Run mariadb image
```bash
docker run -d --name=mariadb_docker -p 50001:3306 -e MYSQL_ROOT_PASSWORD=mypassword mariadb
```

Run asp.net core image
```bash
docker run -d --name webapi_run -p 51234:80 --link mariadb_docker webapi
```

