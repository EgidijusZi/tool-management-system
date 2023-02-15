import { React, useState } from 'react';
import {
  Dialog,
  Typography,
  TextField,
  Button,
  Box,
  FormHelperText,
} from '@mui/material';

const ChangePasswordDialog = ({ open, onDialogClose }) => {
  const [password, setPassword] = useState({
    newPassword: '',
    confirmNewPassword: '',
  });
  const [error, setError] = useState('');

  const handleSubmit = () => {
    if (password.newPassword !== password.confirmNewPassword) {
      setError('New password and confirm new password do not match');
    } else {
      // Perform password change logic here, api call with form...
      setError('');
      setPassword('');
      onDialogClose();
    }
  };

  return (
    <Dialog open={open} onClose={onDialogClose}>
      <Box sx={{ p: 2 }}>
        <Typography variant='h6'>Change Password</Typography>
        <TextField
          type='password'
          label='Current password'
          margin='normal'
          fullWidth
        />
        <TextField
          type='password'
          label='New password'
          margin='normal'
          fullWidth
          onChange={(event) =>
            setPassword({ ...password, newPassword: event.target.value })
          }
        />
        <TextField
          type='password'
          label='Confirm new password'
          margin='normal'
          fullWidth
          onChange={(event) =>
            setPassword({ ...password, confirmNewPassword: event.target.value })
          }
        />
        {error && <FormHelperText error>{error}</FormHelperText>}
        <Box sx={{ display: 'flex', justifyContent: 'flex-end' }}>
          <Button variant='contained' color='primary' onClick={handleSubmit}>
            Submit
          </Button>
        </Box>
      </Box>
    </Dialog>
  );
};

export default ChangePasswordDialog;
