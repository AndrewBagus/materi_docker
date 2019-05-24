Materi docker ini untuk RAY talk tanggal 24 mei 2019

Pembahasan step-07 docker compose

Build Dockerfile to Docker Image
```bash
docker build -t webapi:latest .
```

Run docker compose
```bash
docker-compose up
```
Or run docker compose in detach mode
```bash
docker-compose up -d
```
Stop docker compose
```bash
docker-compose stop
```
Or Stop docker compose and remove container
```bash
docker-compose rm -s
```

