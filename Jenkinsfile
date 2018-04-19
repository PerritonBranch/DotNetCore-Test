pipeline {
  agent {
    docker {
      args '''-p 3000:3000
'''
      image 'microsoft/dotnet'
    }

  }
  stages {
    stage('AddDocker') {
      steps {
        sh 'cat /etc/*-release'
        sh 'whoami'
        sh '''apk update
apk add docker'''
      }
    }
    stage('TestDockerCommands') {
      steps {
        sh 'docker --version'
        sh 'docker ps'
        sh 'docker run hello-world'
      }
    }
  }
}