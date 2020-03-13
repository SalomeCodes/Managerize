# ### STAGE 1: Build ###
# FROM node:12.7-alpine AS build

# # Usage of environment variables is hard in Angular after compile-time
# # So these variables are passed through an ARG
# ARG INVOICE_SERVICE_ENDPOINT
# ENV INVOICE_SERVICE_ENDPOINT = $ENV.INVOICE_SERVICE_ADDR

# WORKDIR /src
# COPY . /src
# RUN npm install
# RUN $(npm bin)/ng build --prod

# ### STAGE 2: Run ###
# FROM nginx:1.17.1-alpine
# WORKDIR /src
# COPY --from=build-env /src/dist/Factura /usr/share/nginx/html
# COPY nginx/nginx.conf /etc/nginx/nginx.conf
# EXPOSE 80
# CMD ["nginx", "-g", "daemon off;"]

# FROM node:12.7-alpine AS build

# ARG ENV.INVOICE_SERVICE_ENDPOINT
# ENV INVOICE_SERVICE_ENDPOINT = $ENV.INVOICE_SERVICE_ENDPOINT

# WORKDIR /usr/src/app
# COPY package.json ./
# RUN npm install
# COPY . .
# RUN npm run build -- --prod

# ### STAGE 2: Run ###
# FROM nginx:1.17.1-alpine
# COPY --from=build /usr/src/app/dist/factura /usr/share/nginx/html
# COPY nginx/nginx.conf /etc/nginx/nginx.conf
# EXPOSE 80
# CMD ["nginx", "-g", "daemon off;"]

#################
# Build the app #
#################
FROM node:12-alpine as build
WORKDIR /app
COPY package.json package-lock.json ./
RUN npm install
COPY . .
RUN npm install -g @angular/cli
RUN ng build --configuration production --output-path=/dist

################
# Run in NGINX #
################
FROM nginx:alpine
COPY --from=build /dist /usr/share/nginx/html
COPY nginx/nginx.conf /etc/nginx/nginx.conf
EXPOSE 80

# When the container starts, replace the env.js with values from environment variables
CMD ["/bin/sh",  "-c",  "envsubst < /usr/share/nginx/html/assets/env.template.js > /usr/share/nginx/html/assets/env.js && exec nginx -g 'daemon off;'"]