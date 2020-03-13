### STAGE 1: Build ###
FROM node:12.7-alpine AS build
WORKDIR /usr/src/app
RUN pwd
COPY Factura/package.json ./
RUN npm install
COPY Factura .
WORKDIR Factura
RUN npm run build

### STAGE 2: Run ###
FROM nginx:1.17.1-alpine
COPY --from=build /usr/src/app/dist/factura /usr/share/nginx/html


#################
# Build the app #
#################
FROM node:12-alpine as build
WORKDIR /app
COPY Factura/package.json Factura/package-lock.json ./
RUN npm install
COPY . .
RUN npm install -g @angular/cli
RUN ng build --configuration production --output-path=/dist

################
# Run in NGINX #
################
FROM nginx:alpine
COPY --from=build Factura/dist /usr/share/nginx/html
COPY nginx/nginx.conf /etc/nginx/nginx.conf
EXPOSE 80

# When the container starts, replace the env.js with values from environment variables
CMD ["/bin/sh",  "-c",  "envsubst < /usr/share/nginx/html/assets/env.template.js > /usr/share/nginx/html/assets/env.js && exec nginx -g 'daemon off;'"]