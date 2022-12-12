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

const LoginPage = () => {
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
              <TextField label='Email' name='email' variant='outlined' />
              <TextField label='Password' name='password' variant='outlined' />
              <Button
                sx={{ width: '90%' }}
                type='submit'
                variant='contained'
                size='large'
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
