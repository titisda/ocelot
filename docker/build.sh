# this script build the ocelot docker file
version=0.0.9
docker build --platform linux/amd64 -t mijitt0m/ocelot-build -f Dockerfile.base .
echo $DOCKER_PASS | docker login -u $DOCKER_USER --password-stdin
docker tag mijitt0m/ocelot-build mijitt0m/ocelot-build:$version
docker push mijitt0m/ocelot-build:latest
docker push mijitt0m/ocelot-build:$version