#Pull Image
#docker pull centos

#Create Container
#docker run -it ubuntu /bin/bash

#Stop and Start Container
#docker stop ..
#docker start ..
#docker attac ..

#Run Multi Container Single Image
docker run -itd --name ubuntu1 ubuntu /bin/bash
docker run -itd --name ubuntu2 ubuntu /bin/bash

#List Image And Container
#docker images (list image)
#docker ps (list container)

#Remove Image And Container
#docker rmi (remove image)
#docker rm (remove container)
