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
c. Stop And Start Container
	- docker stop <name container>
	- docker start <name container>
	- docker attach <name container>

d. Run Multi Container Single Image
	- docker run -itd --name ubuntu1 ubuntu /bin/bash
	- docker run -itd --name ubuntu2 ubuntu /bin/bash

e. List Image And Container
	- docker images <name container> (list image)
	- docker ps <name container> (list container)

f. Remove Image And Container
	- docker rmi <name container> (remove image)
	- docker rm <name container> (remove container)
