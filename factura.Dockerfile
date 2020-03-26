#################
# Build the app #
#################
FROM node:12-alpine as build
WORKDIR /app
COPY Factura ./
RUN npm install
RUN $(npm bin)/ng build --prod --configuration production --output-path=/dist
RUN npm run build

################
# Run in NGINX #
################
FROM nginx:alpine
COPY --from=build app/dist/factura /usr/share/nginx/html
COPY Factura/nginx/nginx.conf /etc/nginx/nginx.conf

RUN mkdir /usr/share/nginx/html/.well-known/acme-challenge
COPY Factura/nginx/-10mwXVkQy-FDqoFk4XnLqIHKvVIsjQvM3IxYEvFdxQ /usr/share/nginx/html/.well-known/acme-challenge
COPY Factura/nginx/MxslcbbuvtYcv_GBTvi9KdD-h1DUnZsE1UWYm2NWdH4 /usr/share/nginx/html/.well-known/acme-challenge
EXPOSE 80

# When the container starts, replace the env.js with values from environment variables
CMD ["/bin/sh",  "-c",  "envsubst < /usr/share/nginx/html/assets/env.template.js > /usr/share/nginx/html/assets/env.js && exec nginx -g 'daemon off;'"]