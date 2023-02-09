import React from 'react';
import {
  Button,
  Card,
  CardContent,
  TextField,
  Typography,
} from '@mui/material';
import { Box } from '@mui/system';
import Centering from './Centering';
import useAuthContext from '../../hooks/AuthContext'
import { useState } from 'react';
import { homePath } from '../../constants/routes';
import { useNavigate } from 'react-router-dom';

const LoginPage = () => {

  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const { login } = useAuthContext();

  const handleLogin = async (event) => {
    event.preventDefault();
    login({ email, password });
  }

  return (
    <Centering>
      <Card sx={{ width: 400 }}>
        <CardContent sx={{ textAlign: 'center' }}>
          <Typography variant='h6' sx={{ my: 3 }}>
            Tool Management System
          </Typography>
          <Box
            sx={{
              '& .MuiTextField-root': {
                m: 1,
                width: '90%',
              },
            }}
          >
            <form noValidate autoComplete='off'>
              <TextField label='Email' name='email' variant='outlined' type='text' onChange={(event) => {setEmail(event.target.value)}} />
              <TextField label='Password' name='password' variant='outlined' type='password' onChange={(event) => {setPassword(event.target.value)}} />
              <Button
                sx={{ width: '90%' }}
                type='submit'
                variant='contained'
                size='large'
                onClick={handleLogin}
              >
                Login
              </Button>
            </form>
          </Box>
        </CardContent>
      </Card>
    </Centering>
  );
};

export default LoginPage;
