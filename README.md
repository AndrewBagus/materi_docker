Materi docker ini untuk RAY talk tanggal 24 mei 2019

Pembahasan step-01 docker basic usage

a. Pull Image
```bash
docker pull centos
```
b. Create Container
```bash
docker run -it ubuntu /bin/bash
```
c. Stop And Start Container
```bash
docker stop <name container>
docker start <name container>
docker attach <name container>
```
d. Run Multi Container Single Image
```bash
docker run -itd --name ubuntu1 ubuntu /bin/bash
docker run -itd --name ubuntu2 ubuntu /bin/bash
```
e. List Image And Container
```bash
docker images <name container> (list image)
docker ps <name container> (list container)
```
	
f. Remove Image And Container
```bash
docker rmi <name container> (remove image)
docker rm <name container> (remove container)
```
