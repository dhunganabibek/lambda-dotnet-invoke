# Lambda dotnet invoke

This project contains a simple AWS Lambda using dotnet as a runtime, SAM for local invoke and write to dynamodb.

## Building the Project

To build the project, navigate to the `src` directory and run:

``` bash
dotnet build
```


## Deploying the Lambda Function

To deploy the Lambda function, use the AWS CLI with the following command:

```
aws lambda create-function \
    --function-name HelloWorldLambda \
    --runtime dotnet6 \
    --handler HelloWorldLambda::HelloWorldLambda.Function::FunctionHandler \
    --zip-file fileb://HelloWorldLambda.zip \
    --role arn:aws:iam::891377073311:role/lambda-admin-role
```

