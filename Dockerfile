#Using glennc/dotnet because the official .NET image isn't being built regularly. This is just a rebuild of the .NET image
#without any changes to get the latest CLI bits. This should be resolved as the new preview repo the team created comes online.
FROM glennc/dotnet

#THis is to work around an issue in LTTNG that is causing an asset to throw the first time you use dotnet inside docker.
#See: https://github.com/dotnet/cli/issues/1582
ENV LTTNG_UST_REGISTER_TIMEOUT 0

# Install libuv for Kestrel from source code (binary is not in wheezy and one in jessie is still too old)
RUN LIBUV_VERSION=1.4.2 \
	&& apt-get -qq update \
	&& apt-get -qqy install autoconf automake build-essential libtool \
	&& curl -sSL https://github.com/libuv/libuv/archive/v${LIBUV_VERSION}.tar.gz | tar zxfv - -C /usr/local/src \
	&& cd /usr/local/src/libuv-$LIBUV_VERSION \
	&& sh autogen.sh && ./configure && make && make install \
	&& rm -rf /usr/local/src/libuv-$LIBUV_VERSION \
	&& ldconfig \
	&& apt-get -y purge autoconf automake build-essential libtool \
	&& apt-get -y autoremove \
	&& apt-get -y clean \
	&& rm -rf /var/lib/apt/lists/*

#Copy and restore project.json to get fastest re-build times if you haven't changed packages, takes advantage
#of dockers build cache.
COPY ./src/Recipies/project.json /source/src/recipies
WORKDIR /source
RUN ["dotnet", "restore"]
#Doing this is safe only if you have a dockerignore file to ignore project.lock.json. Otherwise you can accidentally
#overwrite it with one from the source directory, which will make the app fail at runtime.
COPY . /source
WORKDIR /source/src/Recipes
RUN ["dotnet", "publish", "-o", "/app"]
WORKDIR /app
# I don't think this really gains anything, but probably makes people feel better.
RUN rm -rf /source
EXPOSE 5000
ENTRYPOINT ["/app/Recipes"]