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
COPY --from=build app/dist /usr/share/nginx/html
# COPY nginx/nginx.conf /etc/nginx/nginx.conf
EXPOSE 80

# When the container starts, replace the env.js with values from environment variables
CMD ["/bin/sh",  "-c",  "envsubst < /usr/share/nginx/html/factura/assets/env.template.js > /usr/share/nginx/html/factura/assets/env.js && exec nginx -g 'daemon off;'"]