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

RUN apk add inotify-tools certbot openssl
WORKDIR /opt
COPY Factura/nginx/entrypoint.sh nginx-letsencrypt
COPY Factura/nginx/certbot.sh certbot.sh
COPY Factura/nginx/nginx.conf /etc/nginx/nginx.conf
COPY Factura/nginx/ssl-options/ /etc/ssl-options
RUN chmod +x nginx-letsencrypt && \
    chmod +x certbot.sh 
ENTRYPOINT ["./nginx-letsencrypt"]

COPY --from=build app/dist/factura /usr/share/nginx/html
COPY Factura/nginx/nginx.conf /etc/nginx/nginx.conf

EXPOSE 80

# When the container starts, replace the env.js with values from environment variables
CMD ["/bin/sh",  "-c",  "envsubst < /usr/share/nginx/html/assets/env.template.js > /usr/share/nginx/html/assets/env.js && exec nginx -g 'daemon off;'"]


